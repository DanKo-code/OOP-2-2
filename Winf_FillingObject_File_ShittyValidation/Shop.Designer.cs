namespace Winf_FillingObject_File_ShittyValidation
{
    partial class Shop
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
                //this._storeKeeperLogIn.Dispose();
            }
            base.Dispose(disposing);
            _storeKeeperLogIn.Dispose();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryNumber = new System.Windows.Forms.NumericUpDown();
            this.inventoryNumberText = new System.Windows.Forms.Label();
            this.radioLittleSize = new System.Windows.Forms.RadioButton();
            this.radioMediumSize = new System.Windows.Forms.RadioButton();
            this.radioBigSize = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productType = new System.Windows.Forms.ListBox();
            this.productWeight = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.receiptDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productAmount = new System.Windows.Forms.NumericUpDown();
            this.productPrice = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toProducer = new System.Windows.Forms.Button();
            this.addToStore = new System.Windows.Forms.Button();
            this.showStore = new System.Windows.Forms.Button();
            this.StoreKeeperName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(52, 43);
            this.productName.Multiline = true;
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(156, 71);
            this.productName.TabIndex = 0;
            this.productName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productName_KeyPress);
            this.productName.Validating += new System.ComponentModel.CancelEventHandler(this.productName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название товара";
            // 
            // inventoryNumber
            // 
            this.inventoryNumber.Location = new System.Drawing.Point(276, 67);
            this.inventoryNumber.Name = "inventoryNumber";
            this.inventoryNumber.Size = new System.Drawing.Size(120, 22);
            this.inventoryNumber.TabIndex = 4;
            // 
            // inventoryNumberText
            // 
            this.inventoryNumberText.AutoSize = true;
            this.inventoryNumberText.Location = new System.Drawing.Point(273, 43);
            this.inventoryNumberText.Name = "inventoryNumberText";
            this.inventoryNumberText.Size = new System.Drawing.Size(141, 16);
            this.inventoryNumberText.TabIndex = 5;
            this.inventoryNumberText.Text = "Инвентарный номер";
            // 
            // radioLittleSize
            // 
            this.radioLittleSize.AutoSize = true;
            this.radioLittleSize.Location = new System.Drawing.Point(466, 57);
            this.radioLittleSize.Name = "radioLittleSize";
            this.radioLittleSize.Size = new System.Drawing.Size(72, 20);
            this.radioLittleSize.TabIndex = 6;
            this.radioLittleSize.TabStop = true;
            this.radioLittleSize.Text = "Малый";
            this.radioLittleSize.UseVisualStyleBackColor = true;
            // 
            // radioMediumSize
            // 
            this.radioMediumSize.AutoSize = true;
            this.radioMediumSize.Location = new System.Drawing.Point(466, 83);
            this.radioMediumSize.Name = "radioMediumSize";
            this.radioMediumSize.Size = new System.Drawing.Size(85, 20);
            this.radioMediumSize.TabIndex = 7;
            this.radioMediumSize.TabStop = true;
            this.radioMediumSize.Text = "Средний";
            this.radioMediumSize.UseVisualStyleBackColor = true;
            // 
            // radioBigSize
            // 
            this.radioBigSize.AutoSize = true;
            this.radioBigSize.Location = new System.Drawing.Point(466, 109);
            this.radioBigSize.Name = "radioBigSize";
            this.radioBigSize.Size = new System.Drawing.Size(85, 20);
            this.radioBigSize.TabIndex = 8;
            this.radioBigSize.TabStop = true;
            this.radioBigSize.Text = "Большой";
            this.radioBigSize.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Размер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Тип";
            // 
            // productType
            // 
            this.productType.FormattingEnabled = true;
            this.productType.ItemHeight = 16;
            this.productType.Items.AddRange(new object[] {
            "Новый",
            "БУ",
            "Брак",
            "Немного побитый"});
            this.productType.Location = new System.Drawing.Point(52, 163);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(120, 68);
            this.productType.TabIndex = 11;
            // 
            // productWeight
            // 
            this.productWeight.FormattingEnabled = true;
            this.productWeight.Items.AddRange(new object[] {
            "до 100кг",
            "100кг - 500кг",
            "более 500кг"});
            this.productWeight.Location = new System.Drawing.Point(276, 163);
            this.productWeight.Name = "productWeight";
            this.productWeight.Size = new System.Drawing.Size(120, 72);
            this.productWeight.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Вес";
            // 
            // receiptDate
            // 
            this.receiptDate.Location = new System.Drawing.Point(447, 182);
            this.receiptDate.Name = "receiptDate";
            this.receiptDate.Size = new System.Drawing.Size(200, 22);
            this.receiptDate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата поступления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Кол-во";
            // 
            // productAmount
            // 
            this.productAmount.Location = new System.Drawing.Point(52, 289);
            this.productAmount.Name = "productAmount";
            this.productAmount.Size = new System.Drawing.Size(120, 22);
            this.productAmount.TabIndex = 16;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(276, 288);
            this.productPrice.Mask = "0#####$";
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(100, 22);
            this.productPrice.TabIndex = 18;
            this.productPrice.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Цена";
            // 
            // toProducer
            // 
            this.toProducer.Location = new System.Drawing.Point(291, 358);
            this.toProducer.Name = "toProducer";
            this.toProducer.Size = new System.Drawing.Size(135, 46);
            this.toProducer.TabIndex = 20;
            this.toProducer.Text = "Производитель";
            this.toProducer.UseVisualStyleBackColor = true;
            this.toProducer.Click += new System.EventHandler(this.toProducer_Click);
            // 
            // addToStore
            // 
            this.addToStore.Location = new System.Drawing.Point(428, 264);
            this.addToStore.Name = "addToStore";
            this.addToStore.Size = new System.Drawing.Size(123, 46);
            this.addToStore.TabIndex = 21;
            this.addToStore.Text = "Добавить на склад";
            this.addToStore.UseVisualStyleBackColor = true;
            this.addToStore.Click += new System.EventHandler(this.addToStore_Click);
            // 
            // showStore
            // 
            this.showStore.Location = new System.Drawing.Point(585, 265);
            this.showStore.Name = "showStore";
            this.showStore.Size = new System.Drawing.Size(123, 46);
            this.showStore.TabIndex = 22;
            this.showStore.Text = "Показать склад";
            this.showStore.UseVisualStyleBackColor = true;
            this.showStore.Click += new System.EventHandler(this.showStore_Click);
            // 
            // StoreKeeperName
            // 
            this.StoreKeeperName.AutoSize = true;
            this.StoreKeeperName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoreKeeperName.Location = new System.Drawing.Point(562, 34);
            this.StoreKeeperName.Name = "StoreKeeperName";
            this.StoreKeeperName.Size = new System.Drawing.Size(146, 20);
            this.StoreKeeperName.TabIndex = 23;
            this.StoreKeeperName.Text = "StoreKeeperName";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(746, 432);
            this.Controls.Add(this.StoreKeeperName);
            this.Controls.Add(this.showStore);
            this.Controls.Add(this.addToStore);
            this.Controls.Add(this.toProducer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.receiptDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productWeight);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioBigSize);
            this.Controls.Add(this.radioMediumSize);
            this.Controls.Add(this.radioLittleSize);
            this.Controls.Add(this.inventoryNumberText);
            this.Controls.Add(this.inventoryNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productName);
            this.Name = "Shop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.inventoryNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inventoryNumber;
        private System.Windows.Forms.Label inventoryNumberText;
        private System.Windows.Forms.RadioButton radioLittleSize;
        private System.Windows.Forms.RadioButton radioMediumSize;
        private System.Windows.Forms.RadioButton radioBigSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox productType;
        private System.Windows.Forms.CheckedListBox productWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker receiptDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown productAmount;
        private System.Windows.Forms.MaskedTextBox productPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button toProducer;
        private System.Windows.Forms.Button addToStore;
        private System.Windows.Forms.Button showStore;
        public System.Windows.Forms.Label StoreKeeperName;
    }
}