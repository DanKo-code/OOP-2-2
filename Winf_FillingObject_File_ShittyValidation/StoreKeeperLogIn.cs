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
    public partial class StoreKeeperLogIn : Form
    {
        public StoreKeeperLogIn()
        {
            InitializeComponent();
        }

        private void toShop_Click(object sender, EventArgs e)
        {
            if (fullNameStoreKeeper.Text == "" || streetStoreKeeper.Text == "" || houseStoreKeeper.Text == "")
            {
                MessageBox.Show("Текстовые поля не должны быть пустые!");
                return;
            }

            string fullName = fullNameStoreKeeper.Text;
            int experience = ((int)experienceStoreKeeper.Value);
            string street = streetStoreKeeper.Text;
            int houseNumber = Convert.ToInt32(houseStoreKeeper.Text);

            StoreKeeper storeKeeper = new StoreKeeper(fullName, experience, street, houseNumber);

            Shop shop = new Shop(storeKeeper, this);

            this.Hide();
            shop.StoreKeeperName.Text = this.fullNameStoreKeeper.Text;
            shop.Show();
        }

        private void StoreKeeper_Click(object sender, EventArgs e)
        {
            StoreKeeper.Dispose();

            if(StoreKeeper.IsDisposed)
            MessageBox.Show("Надпись удалена!");

            newButton = new System.Windows.Forms.Button();
            newButton.Location = new System.Drawing.Point(81, 39);

            newButton.Name = "Появись!";
            newButton.Click += new System.EventHandler(newButton_Click);

            this.toShop.UseVisualStyleBackColor = true;


            this.Controls.Add(newButton);

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            newButton.Dispose();
            StoreKeeper = new System.Windows.Forms.Label();

            this.StoreKeeper.AutoSize = true;
            this.StoreKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoreKeeper.Location = new System.Drawing.Point(81, 39);
            this.StoreKeeper.Name = "StoreKeeper";
            this.StoreKeeper.Size = new System.Drawing.Size(200, 38);
            this.StoreKeeper.TabIndex = 0;
            this.StoreKeeper.Text = "StoreKeeper";
            this.StoreKeeper.Click += new System.EventHandler(this.StoreKeeper_Click);

            Controls.Add(StoreKeeper);
        }
    }
}
