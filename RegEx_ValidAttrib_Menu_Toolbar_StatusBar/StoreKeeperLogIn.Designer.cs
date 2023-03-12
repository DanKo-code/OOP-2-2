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
            this.toShop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adressStoreKeeper = new System.Windows.Forms.MaskedTextBox();
            this.По_быстромуStoreKeeper = new System.Windows.Forms.Button();
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
            // 
            // fullNameStoreKeeper
            // 
            this.fullNameStoreKeeper.Location = new System.Drawing.Point(124, 120);
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
            this.experienceStoreKeeper.Location = new System.Drawing.Point(119, 183);
            this.experienceStoreKeeper.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.experienceStoreKeeper.Name = "experienceStoreKeeper";
            this.experienceStoreKeeper.Size = new System.Drawing.Size(120, 22);
            this.experienceStoreKeeper.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Стаж";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Адрес(Улица, Дом)";
            // 
            // adressStoreKeeper
            // 
            this.adressStoreKeeper.Location = new System.Drawing.Point(124, 246);
            this.adressStoreKeeper.Name = "adressStoreKeeper";
            this.adressStoreKeeper.Size = new System.Drawing.Size(100, 22);
            this.adressStoreKeeper.TabIndex = 10;
            // 
            // По_быстромуStoreKeeper
            // 
            this.По_быстромуStoreKeeper.Location = new System.Drawing.Point(288, 12);
            this.По_быстромуStoreKeeper.Name = "По_быстромуStoreKeeper";
            this.По_быстромуStoreKeeper.Size = new System.Drawing.Size(70, 70);
            this.По_быстромуStoreKeeper.TabIndex = 12;
            this.По_быстромуStoreKeeper.Text = "По-быстрому";
            this.По_быстромуStoreKeeper.UseVisualStyleBackColor = true;
            this.По_быстромуStoreKeeper.Click += new System.EventHandler(this.По_быстромуStoreKeeper_Click);
            // 
            // StoreKeeperLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(370, 343);
            this.Controls.Add(this.По_быстромуStoreKeeper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adressStoreKeeper);
            this.Controls.Add(this.toShop);
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
        private System.Windows.Forms.Button toShop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox adressStoreKeeper;
        private System.Windows.Forms.Button По_быстромуStoreKeeper;
    }
}

