namespace Winf_FillingObject_File_ShittyValidation
{
    partial class StoreKeeperLogIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StoreKeeper = new System.Windows.Forms.Label();
            this.fullNameStoreKeeper = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.experienceStoreKeeper = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toShop = new System.Windows.Forms.Button();
            this.houseStoreKeeper = new System.Windows.Forms.MaskedTextBox();
            this.streetStoreKeeper = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.experienceStoreKeeper)).BeginInit();
            this.SuspendLayout();
            // 
            // StoreKeeper
            // 
            this.StoreKeeper.AutoSize = true;
            this.StoreKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoreKeeper.Location = new System.Drawing.Point(81, 39);
            this.StoreKeeper.Name = "StoreKeeper";
            this.StoreKeeper.Size = new System.Drawing.Size(200, 38);
            this.StoreKeeper.TabIndex = 0;
            this.StoreKeeper.Text = "StoreKeeper";
            this.StoreKeeper.Click += new System.EventHandler(this.StoreKeeper_Click);
            // 
            // fullNameStoreKeeper
            // 
            this.fullNameStoreKeeper.Location = new System.Drawing.Point(124, 120);
            this.fullNameStoreKeeper.Mask = "L.L.LL??????????";
            this.fullNameStoreKeeper.Name = "fullNameStoreKeeper";
            this.fullNameStoreKeeper.Size = new System.Drawing.Size(100, 22);
            this.fullNameStoreKeeper.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО";
            // 
            // experienceStoreKeeper
            // 
            this.experienceStoreKeeper.Location = new System.Drawing.Point(124, 191);
            this.experienceStoreKeeper.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.experienceStoreKeeper.Name = "experienceStoreKeeper";
            this.experienceStoreKeeper.Size = new System.Drawing.Size(120, 22);
            this.experienceStoreKeeper.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Стаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Улица";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дом";
            // 
            // toShop
            // 
            this.toShop.Location = new System.Drawing.Point(124, 287);
            this.toShop.Name = "toShop";
            this.toShop.Size = new System.Drawing.Size(100, 46);
            this.toShop.TabIndex = 9;
            this.toShop.Text = "Вход";
            this.toShop.UseVisualStyleBackColor = true;
            this.toShop.Click += new System.EventHandler(this.toShop_Click);
            // 
            // houseStoreKeeper
            // 
            this.houseStoreKeeper.Location = new System.Drawing.Point(217, 247);
            this.houseStoreKeeper.Mask = "099";
            this.houseStoreKeeper.Name = "houseStoreKeeper";
            this.houseStoreKeeper.Size = new System.Drawing.Size(100, 22);
            this.houseStoreKeeper.TabIndex = 10;
            // 
            // streetStoreKeeper
            // 
            this.streetStoreKeeper.Location = new System.Drawing.Point(42, 247);
            this.streetStoreKeeper.Mask = "LLL?????????????????";
            this.streetStoreKeeper.Name = "streetStoreKeeper";
            this.streetStoreKeeper.Size = new System.Drawing.Size(100, 22);
            this.streetStoreKeeper.TabIndex = 11;
            // 
            // StoreKeeperLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(370, 343);
            this.Controls.Add(this.streetStoreKeeper);
            this.Controls.Add(this.houseStoreKeeper);
            this.Controls.Add(this.toShop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.experienceStoreKeeper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullNameStoreKeeper);
            this.Controls.Add(this.StoreKeeper);
            this.Name = "StoreKeeperLogIn";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.experienceStoreKeeper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StoreKeeper;
        private System.Windows.Forms.MaskedTextBox fullNameStoreKeeper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown experienceStoreKeeper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button toShop;
        private System.Windows.Forms.MaskedTextBox houseStoreKeeper;
        private System.Windows.Forms.MaskedTextBox streetStoreKeeper;

        //Мой высер для показа удаления/создания эу
        private System.Windows.Forms.Button newButton;
    }
}

