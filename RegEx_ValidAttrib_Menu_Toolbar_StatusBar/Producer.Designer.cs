using System.Windows.Forms;

namespace Winf_FillingObject_File_ShittyValidation
{
    partial class Producer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            //base.Dispose(disposing);
            this.Hide();

            if(!this._Shop.IsDisposed)
            this._Shop.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.phoneProducer = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toShop = new System.Windows.Forms.Button();
            this.countryProducer = new System.Windows.Forms.MaskedTextBox();
            this.cityProducer = new System.Windows.Forms.MaskedTextBox();
            this.organizationProducer = new System.Windows.Forms.MaskedTextBox();
            this.По_быстромуProducer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producer";
            // 
            // phoneProducer
            // 
            this.phoneProducer.Location = new System.Drawing.Point(142, 258);
            this.phoneProducer.Name = "phoneProducer";
            this.phoneProducer.Size = new System.Drawing.Size(100, 22);
            this.phoneProducer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Организация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Город";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Страна";
            // 
            // toShop
            // 
            this.toShop.Location = new System.Drawing.Point(100, 305);
            this.toShop.Name = "toShop";
            this.toShop.Size = new System.Drawing.Size(190, 37);
            this.toShop.TabIndex = 13;
            this.toShop.Text = "Вернуться в магазин";
            this.toShop.UseVisualStyleBackColor = true;
            this.toShop.Click += new System.EventHandler(this.toShop_Click);
            // 
            // countryProducer
            // 
            this.countryProducer.Location = new System.Drawing.Point(68, 192);
            this.countryProducer.Name = "countryProducer";
            this.countryProducer.Size = new System.Drawing.Size(100, 22);
            this.countryProducer.TabIndex = 14;
            // 
            // cityProducer
            // 
            this.cityProducer.Location = new System.Drawing.Point(242, 192);
            this.cityProducer.Name = "cityProducer";
            this.cityProducer.Size = new System.Drawing.Size(100, 22);
            this.cityProducer.TabIndex = 15;
            // 
            // organizationProducer
            // 
            this.organizationProducer.Location = new System.Drawing.Point(142, 121);
            this.organizationProducer.Name = "organizationProducer";
            this.organizationProducer.Size = new System.Drawing.Size(100, 22);
            this.organizationProducer.TabIndex = 16;
            // 
            // По_быстромуProducer
            // 
            this.По_быстромуProducer.Location = new System.Drawing.Point(299, 12);
            this.По_быстромуProducer.Name = "По_быстромуProducer";
            this.По_быстромуProducer.Size = new System.Drawing.Size(70, 70);
            this.По_быстромуProducer.TabIndex = 17;
            this.По_быстромуProducer.Text = "По-быстрому";
            this.По_быстромуProducer.UseVisualStyleBackColor = true;
            this.По_быстромуProducer.Click += new System.EventHandler(this.По_быстромуProducer_Click);
            // 
            // Producer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(381, 402);
            this.Controls.Add(this.По_быстромуProducer);
            this.Controls.Add(this.organizationProducer);
            this.Controls.Add(this.cityProducer);
            this.Controls.Add(this.countryProducer);
            this.Controls.Add(this.toShop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneProducer);
            this.Controls.Add(this.label1);
            this.Name = "Producer";
            this.Text = "Producer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox phoneProducer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button toShop;
        private System.Windows.Forms.MaskedTextBox countryProducer;
        private System.Windows.Forms.MaskedTextBox cityProducer;
        private System.Windows.Forms.MaskedTextBox organizationProducer;
        private Button По_быстромуProducer;
    }
}