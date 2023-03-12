using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winf_FillingObject_File_ShittyValidation
{
    public partial class ProductTypeSearch : Form
    {
        private Shop _shop;

        public ProductTypeSearch(Shop shop)
        {
            InitializeComponent();
            _shop = shop;
        }

        // Super constructor!!!
        public ProductTypeSearch(Shop shop, string productType)
        {
            InitializeComponent();
            _shop = shop;

            textBox1.Text = productType;
            button1_Click(button1, new EventArgs());
            _shop.modifiedShopStore.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // В начале ищем на полное соответствие
            List<ShopTemplate> tempBuffer = _shop.ModifideBufferShopTemplates.Where(x => x._type == textBox1.Text).ToList();
            if (tempBuffer.Count > 0)
            {
                _shop.ModifideBufferShopTemplates = tempBuffer;
                _shop.PrintModifiedShopStore();

                _shop.backForth.Add();
                return;
            }

            // Поиск на основе regex 
            Regex regex = new Regex(@"Новый|БУ|Брак|Немного побитый");
            MatchCollection matchCollection = regex.Matches(textBox1.Text);

            if (matchCollection.Count > 0)
            {
                tempBuffer = _shop.ModifideBufferShopTemplates.Where
                    (x =>
                    {
                        foreach (Match item in matchCollection)
                        {
                            if (x._type == item.ToString())
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                    ).ToList();

                if (tempBuffer.Count > 0)
                {
                    _shop.ModifideBufferShopTemplates = tempBuffer;
                    _shop.PrintModifiedShopStore();

                    _shop.backForth.Add();
                    return;
                }
            }

            MessageBox.Show("По вашему запросу не удалось ничего найти :(");
        }
    }
}
