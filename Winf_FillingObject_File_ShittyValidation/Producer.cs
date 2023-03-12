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
    public partial class Producer : Form
    {
        private ProducerTemplate _producerTemplate;
        private Shop _Shop;

        public Producer(Shop shop)
        {
            _Shop = shop;
            InitializeComponent();
        }

        private void toShop_Click(object sender, EventArgs e)
        {
            if (organizationProducer.Text == "" || countryProducer.Text == "" || cityProducer.Text == "" || phoneProducer.Text == "")
            {
                MessageBox.Show("Текстовые поля не должны быть пустые!");
                return;
            }

            string _organization = organizationProducer.Text;
            string _country = countryProducer.Text;
            string _city = cityProducer.Text;
            string _phone = phoneProducer.Text;

            _producerTemplate = new ProducerTemplate(_organization, _country, _city, _phone);

            this.Hide();

            _Shop.Show();
        }

        public ProducerTemplate GetProducer() 
            { return _producerTemplate; }
    }
}
