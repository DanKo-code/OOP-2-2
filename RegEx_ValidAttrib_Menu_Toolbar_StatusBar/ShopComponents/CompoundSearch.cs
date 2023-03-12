using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winf_FillingObject_File_ShittyValidation
{
    public partial class CompoundSearch : Form
    {
        private Shop _shop;

        public CompoundSearch(Shop shop)
        {
            InitializeComponent();
            _shop = shop;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
            textBox1.Text = "";
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = !groupBox2.Visible;
            textBox2.Text = "";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = !groupBox3.Visible;
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(groupBox1.Visible)
            {
                ProductNameSearch productNameSearch = new ProductNameSearch(_shop, textBox1.Text);
            }

            if (groupBox2.Visible)
            {
                ProductTypeSearch productTypeSearch = new ProductTypeSearch(_shop, textBox2.Text);
            }

            if(groupBox3.Visible)
            {
                ProductPriceSearch productPriceSearch = new ProductPriceSearch(_shop, textBox3.Text, textBox4.Text);
            }

            _shop.PrintModifiedShopStore();
        }
    }
}
