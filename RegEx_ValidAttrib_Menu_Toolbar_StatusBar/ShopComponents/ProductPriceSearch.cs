using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winf_FillingObject_File_ShittyValidation
{
    public partial class ProductPriceSearch : Form
    {
        private Shop _shop;

        public ProductPriceSearch(Shop shop)
        {
            InitializeComponent();
            _shop = shop;
        }

        // Super constructor!!!
        public ProductPriceSearch(Shop shop, string priceFrom, string priceTo)
        {
            InitializeComponent();
            _shop = shop;

            textBox1.Text = priceFrom;
            textBox2.Text = priceTo;
            button1_Click(button1, new EventArgs());
            _shop.modifiedShopStore.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex pricePattern = new Regex(@"^\d+(\.\d{1,2})?$");

            List<ShopTemplate> tempBuffer;

            if (pricePattern.IsMatch(textBox1.Text) && pricePattern.IsMatch(textBox2.Text))
            {
                tempBuffer = _shop.ModifideBufferShopTemplates.Where
                    (
                        x => 
                        {
                            double tb1;
                            double tb2;
                            double pr;

                            if(textBox1.Text.IndexOf('.') > -1)
                            {
                                tb1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                tb1 = int.Parse(textBox1.Text);
                            }

                            if (textBox2.Text.IndexOf('.') > -1)
                            {
                                tb2 = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                tb2 = int.Parse(textBox2.Text);
                            }

                            if(x._price.IndexOf('.') > -1)
                            {
                                pr = double.Parse(x._price, CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                pr = int.Parse(x._price);
                            }

                            return pr >= tb1 && pr <= tb2;
                        }

                    ).ToList();

                if(tempBuffer.Count > 0)
                {
                    _shop.ModifideBufferShopTemplates = tempBuffer;
                    _shop.PrintModifiedShopStore();

                    _shop.backForth.Add();
                    return;
                }
            }

            else if (pricePattern.IsMatch(textBox1.Text) && textBox2.Text == "")
            {
                tempBuffer = _shop.ModifideBufferShopTemplates.Where
                    (
                        x =>
                        {
                            double tb1;
                            double pr;

                            if (textBox1.Text.IndexOf('.') > -1)
                            {
                                tb1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                tb1 = int.Parse(textBox1.Text);
                            }

                            if (x._price.IndexOf('.') > -1)
                            {
                                pr = double.Parse(x._price, CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                pr = int.Parse(x._price);
                            }

                            return pr >= tb1;
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

            else if (textBox1.Text == "" && pricePattern.IsMatch(textBox2.Text))
            {
                tempBuffer = _shop.ModifideBufferShopTemplates.Where
                    (
                        x =>
                        {
                            double tb2;
                            double pr;

                            if (textBox2.Text.IndexOf('.') > -1)
                            {
                                tb2 = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                tb2 = int.Parse(textBox2.Text);
                            }

                            if (x._price.IndexOf('.') > -1)
                            {
                                pr = double.Parse(x._price, CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                pr = int.Parse(x._price);
                            }

                            return pr <= tb2;
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

            if (!pricePattern.IsMatch(textBox1.Text) || !pricePattern.IsMatch(textBox2.Text))
            {
                MessageBox.Show("Неверный формат диапазона цены!");
                return;
            }

            MessageBox.Show("По вашему запросу не удалось ничего найти :(");
        }
    }
}
