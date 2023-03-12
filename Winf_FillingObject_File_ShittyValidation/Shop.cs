using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
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

        private Producer _producer;

        public Shop(StoreKeeper storeKeeperInf, StoreKeeperLogIn storeKeeperLogIn)
        {
            InitializeComponent();
            _storeKeeperInf = storeKeeperInf;
            _storeKeeperLogIn = storeKeeperLogIn;
        }

        private void addToStore_Click(object sender, EventArgs e)
        {
            // Сделать проверку на заполнение производителя!!!

            if ((radioLittleSize.Checked || radioMediumSize.Checked || radioBigSize.Checked) == false)
            {
                MessageBox.Show("Выберите размер!");
                return;
            }

            if (productType.Text == "")
            {
                MessageBox.Show("Выберите тип!");
                return;
            }

            if (productWeight.Text == "")
            {
                MessageBox.Show("Выберите вес!");
                return;
            }

            try
            {
                int.Parse(productPrice.Text, System.Globalization.NumberStyles.Currency);
            }
            catch
            {
                MessageBox.Show("Выберите цену!");
                return;
            }

           string _productName = productName.Text;
           int _inventoryNumber = (int)inventoryNumber.Value;

            string _size;
            if (radioLittleSize.Checked)
            {
                _size = radioLittleSize.Text;
            }
            else if(radioMediumSize.Checked)
            {
                _size = radioMediumSize.Text;
            }
            else
            {
                _size = radioBigSize.Text;
            }

           string _type = productType.Text;

           string _weight = productWeight.Text;


           string _date = receiptDate.Text;

           int _amount = (int)productAmount.Value;

           int _price = int.Parse(productPrice.Text, System.Globalization.NumberStyles.Currency);

            _shopTemplate = new ShopTemplate(_productName, _inventoryNumber, _size, _type, _weight, _date, _amount, _price);

            _shopTemplate._storeKeeper = _storeKeeperInf;

            try
            {
                _shopTemplate._producer = _producer.GetProducer();
            }
            catch
            {
                MessageBox.Show("Заполните производителя!");
                return;
            }

            using (FileStream fs = new FileStream("ShopStore.xml", FileMode.Create))
            {
                DataContractSerializer xmlFormatter = new DataContractSerializer(typeof(ShopTemplate));
                xmlFormatter.WriteObject(fs, _shopTemplate);
            }
        }

        private void showStore_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("ShopStore.xml", FileMode.Open))
            {
                DataContractSerializer xmlFormatter = new DataContractSerializer(typeof(ShopTemplate));
                ShopTemplate temp = (ShopTemplate)xmlFormatter.ReadObject(fs);

                MessageBox.Show(temp.ToString());
            }
        }

        private void toProducer_Click(object sender, EventArgs e)
        {
            this.Hide();

            _producer = new Producer(this);

            _producer.Show();
        }

        //После каждого нажатия клавиши
        private void productName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        //Validating + вылазит иконка
        ErrorProvider errorProvider = new ErrorProvider();
        private void productName_Validating(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                
                errorProvider.SetError((Control)sender, "Поле не может быть пустым!");

                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
            }
                


        }
    }
}
