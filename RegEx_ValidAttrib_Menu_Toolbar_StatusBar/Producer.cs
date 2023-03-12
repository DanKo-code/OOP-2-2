using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            string _organization = organizationProducer.Text;
            string _country = countryProducer.Text;
            string _city = cityProducer.Text;
            string _phone = phoneProducer.Text;

            _producerTemplate = new ProducerTemplate(_organization, _country, _city, _phone);

            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(_producerTemplate, new ValidationContext(_producerTemplate), results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }

                return;
            }

            this.Hide();

            _Shop.Show();
        }

        public ProducerTemplate GetProducer() 
            { return _producerTemplate; }

        private void По_быстромуProducer_Click(object sender, EventArgs e)
        {
            organizationProducer.Text = "Ишлянге";
            countryProducer.Text = "Германия";
            cityProducer.Text = "Берлин";
            phoneProducer.Text = "+375(1)1234567";
        }
    }
}
