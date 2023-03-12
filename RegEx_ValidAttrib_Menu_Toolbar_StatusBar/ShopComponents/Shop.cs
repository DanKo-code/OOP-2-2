using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winf_FillingObject_File_ShittyValidation
{
    public partial class Shop : Form
    {
        private StoreKeeper _storeKeeperInf;
        private StoreKeeperLogIn _storeKeeperLogIn;
        public ProducerTemplate _producerInf;
        public ShopTemplate _shopTemplate;

        public List<ShopTemplate> GetSetBufferShopTemplates;
        public List<ShopTemplate> ModifideBufferShopTemplates = new List<ShopTemplate>();

        // строка состояния!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!111

        /// счетчик кол-ва объектов для нижней строки состояния
        //public int numOfObjects = 0;
        /// поля для даты\времени
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        ToolStripLabel eventLabel;
        Timer timer;

        DataContractSerializer xmlFormatter = new DataContractSerializer(typeof(List<ShopTemplate>));

        private Producer _producer;

        public BackForth backForth;

        public Shop(StoreKeeper storeKeeperInf, StoreKeeperLogIn storeKeeperLogIn)
        {
            InitializeComponent();
            _storeKeeperInf = storeKeeperInf;
            _storeKeeperLogIn = storeKeeperLogIn;

            try
            {
                using (FileStream fs = new FileStream("ShopStore.xml", FileMode.Open))
                {
                    GetSetBufferShopTemplates = (List<ShopTemplate>)xmlFormatter.ReadObject(fs);
                    toolStripStatusLabel1.Text = $"Кол-во объектов {GetSetBufferShopTemplates.Count}";
                }
            }
            catch
            {
                GetSetBufferShopTemplates = new List<ShopTemplate>();
            }

            backForth = new BackForth(this);

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            
            /// код с метанита для таймера даты и времени
            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            eventLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            statusStrip1.Items.Add(eventLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void addToStore_Click(object sender, EventArgs e)
        {
           string _productName = productName.Text;
           string _inventoryNumber = inventoryNumber.Text;

           string _size;
           if (radioLittleSize.Checked)
           {
               _size = radioLittleSize.Text;
           }
           else if(radioMediumSize.Checked)
           {
               _size = radioMediumSize.Text;
           }
           else if(radioBigSize.Checked)
           {
               _size = radioBigSize.Text;
           }
           else 
           {
               _size = "";
           }

           string _type = productType.Text;

           string _weight = productWeight.Text;


            DateTime _date = DateTime.Parse(receiptDate.Text);

           int _amount = (int)productAmount.Value;

           string _price = productPrice.Text;

            _shopTemplate = new ShopTemplate(_productName, _inventoryNumber, _size, _type, _weight, _date, _amount, _price);

            // Проверка на валиднасть объекта
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(_shopTemplate, new ValidationContext(_shopTemplate), results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }

                return;
            }

            _shopTemplate._storeKeeper = _storeKeeperInf;

            ////////////////////////////////////////////////////////////////////
            try
            {
                _shopTemplate._producer = _producer.GetProducer();
            }
            catch
            {
                MessageBox.Show("Заполните производителя!");
                return;
            }
           
            using (FileStream fs = new FileStream("ShopStore.xml", FileMode.OpenOrCreate))
            {
                

                if (fs.Length > 0)
                {
                    GetSetBufferShopTemplates = (List<ShopTemplate>)xmlFormatter.ReadObject(fs);
                    fs.SetLength(0);
                }

                GetSetBufferShopTemplates.Add(_shopTemplate);
                xmlFormatter.WriteObject(fs, GetSetBufferShopTemplates);
            }

            MessageBox.Show("Товар добавлен на склад");

            //Для нижней панельки
            toolStripStatusLabel1.Text = $"Кол-во объектов {GetSetBufferShopTemplates.Count}";
        }

        private void showStore_Click(object sender, EventArgs e)
        {
            List<ShopTemplate> temp;

            try
            {
                using (FileStream fs = new FileStream("ShopStore.xml", FileMode.Open))
                {
                    temp = (List<ShopTemplate>)xmlFormatter.ReadObject(fs);
                }
            }
            catch
            {
                MessageBox.Show("Склад пуст!");
                return;
            }
            

            StringBuilder sb = new StringBuilder();
            foreach (ShopTemplate tempItem in temp)
            {
                sb.Append("=========================================\r\n\r\n");
                sb.Append(tempItem.ToString());
                sb.Append("=========================================\r\n\r\n");
            }

            ShopStore shopStore = new ShopStore();
            shopStore.textBox1.Text = sb.ToString();
            shopStore.Show();
        }

        private void toProducer_Click(object sender, EventArgs e)
        {
            this.Hide();

            _producer = new Producer(this);

            _producer.Show();
        }

        private void По_быстромуShop_Click(object sender, EventArgs e)
        {
            productName.Text = "Красный кирпич";
            inventoryNumber.Text = "ИН 000001";
            radioLittleSize.Checked = true;
            productType.SelectedIndex = 0;
            productWeight.SelectedIndex = 0;
            productPrice.Text = "100.25";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия 2.0\n" +
                            "ФИО Разработчика: Козляковский Данила Александрович");
            ection.Text = "Инф. о программе";
        }

        // Print Modified ShopStore
        public ModifiedShopStore modifiedShopStore;
        public void PrintModifiedShopStore()
        {
            StringBuilder sb = new StringBuilder();
            foreach (ShopTemplate tempItem in ModifideBufferShopTemplates)
            {
                sb.Append("=========================================\r\n\r\n");
                sb.Append(tempItem.ToString());
                sb.Append("=========================================\r\n\r\n");
            }

            modifiedShopStore = new ModifiedShopStore();
            modifiedShopStore.textBox1.Text = sb.ToString();
            modifiedShopStore.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("ModifiedShopStore.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.WriteObject(fs, ModifideBufferShopTemplates);
                MessageBox.Show("Результат запросов(модификации) сохранены в файл ModifiedShopStore.xml");
                ection.Text = "Сохранение";
            }
        }

        //кнопки старта Search
        private void названиеТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductNameSearch productNameSearch = new ProductNameSearch(this);
            productNameSearch.Show();
            ection.Text = "Поиск(название товара)";
        }

        private void типТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductTypeSearch productTypeSearch = new ProductTypeSearch(this);
            productTypeSearch.Show();
            ection.Text = "Поиск(тип товара)";
        }

        private void диапазонЦенТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPriceSearch productPriceSearch = new ProductPriceSearch(this);
            productPriceSearch.Show();
            ection.Text = "Поиск(диапазон цен)";
        }

        private void поНесколькимКритериямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompoundSearch compoundSearch = new CompoundSearch(this);
            compoundSearch.Show();
            ection.Text = "Поиск(по нескольким)";
        }

        // Тупое повторение поиска
        private void названиеТовараToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProductNameSearch productNameSearch = new ProductNameSearch(this);
            productNameSearch.Show();
            ection.Text = "Поиск(название товара)";
        }

        private void типТовараToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductTypeSearch productTypeSearch = new ProductTypeSearch(this);
            productTypeSearch.Show();
            ection.Text = "Поиск(тип товара)";
        }

        private void диапазонЦенТовараToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductPriceSearch productPriceSearch = new ProductPriceSearch(this);
            productPriceSearch.Show();
            ection.Text = "Поиск(диапазон цен)";
        }

        private void поНесколькимКритериямToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CompoundSearch compoundSearch = new CompoundSearch(this);
            compoundSearch.Show();
            ection.Text = "Поиск(по нескольким)";
        }

        // Тупое повторение сортировок
        private void поДатеПоступленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifideBufferShopTemplates = ModifideBufferShopTemplates.OrderBy(x => x._date).ToList();
            PrintModifiedShopStore();
            backForth.Add();
            ection.Text = "Сортировка по(дате)";
        }

        private void странаПроизодителяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifideBufferShopTemplates = ModifideBufferShopTemplates.OrderBy(x => x._producer._country).ToList();
            PrintModifiedShopStore();
            backForth.Add();
            ection.Text = "Сортировка(страна производ.)";
        }

        private void названиеТовараToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ModifideBufferShopTemplates = ModifideBufferShopTemplates.OrderBy(x => x._productName).ToList();
            PrintModifiedShopStore();
            backForth.Add();
            ection.Text = "Сортировка(название товара)";
        }

        // Отчистить
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            productName.Text = "";
            inventoryNumber.Text = "";

            radioLittleSize.Checked = false;
            radioMediumSize.Checked = false;
            radioBigSize.Checked = false;

            for (int i = 0; i < productType.Items.Count; i++)
                productType.SetSelected(i, false);

            for (int i = 0; i < productWeight.Items.Count; i++)
            {
                productWeight.SetSelected(i, false);
                productWeight.SetItemCheckState(i, CheckState.Unchecked);
            }
               
            receiptDate.Text = "";

            productAmount.Value = 100;

            productPrice.Text = "";
            ection.Text = "Отчистка ЭУ";
        }

        // Удалить последний товар
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("ShopStore.xml", FileMode.Open))
            {
                if (fs.Length == 0)
                {
                    MessageBox.Show("Склад пуст!");
                    return;
                }

                List<ShopTemplate> temp = (List<ShopTemplate>)xmlFormatter.ReadObject(fs);

                fs.SetLength(0);

                if (temp.Count != 0)
                    temp.RemoveAt(temp.Count - 1);
                else
                {
                    temp.Clear();
                    return;
                }
                    

                xmlFormatter.WriteObject(fs, temp);

                //Для нижней панельки
                toolStripStatusLabel1.Text = $"Кол-во объектов {temp.Count}";
                ection.Text = "Удаление последнего";
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            backForth.Back();
            PrintModifiedShopStore();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            backForth.Forth();
            PrintModifiedShopStore();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;

            if (button1.Text == "Скрыть")
                button1.Text = "Отобразить";
            else
                button1.Text = "Скрыть";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifideBufferShopTemplates = GetSetBufferShopTemplates;
            PrintModifiedShopStore();
        }
    }
}
