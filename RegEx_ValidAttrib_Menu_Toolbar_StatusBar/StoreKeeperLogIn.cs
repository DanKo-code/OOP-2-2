using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winf_FillingObject_File_ShittyValidation
{
    public partial class StoreKeeperLogIn : Form
    {
        public StoreKeeperLogIn()
        {
            InitializeComponent();
        }

        private void toShop_Click(object sender, EventArgs e)
        {
            string fullName = fullNameStoreKeeper.Text;
            int experience = ((int)experienceStoreKeeper.Value);
            string address = adressStoreKeeper.Text;

            StoreKeeper storeKeeper = new StoreKeeper(fullName, experience, address);

            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(storeKeeper, new ValidationContext(storeKeeper), results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }

                return;
            }

            Shop shop = new Shop(storeKeeper, this);

            this.Hide();
            shop.StoreKeeperName.Text = this.fullNameStoreKeeper.Text;
            shop.Show();
        }

        private void По_быстромуStoreKeeper_Click(object sender, EventArgs e)
        {
            fullNameStoreKeeper.Text = "Козляковский Д.А";
            experienceStoreKeeper.Text = "5";
            adressStoreKeeper.Text = "Белорусская 21";
        }
    }
}
