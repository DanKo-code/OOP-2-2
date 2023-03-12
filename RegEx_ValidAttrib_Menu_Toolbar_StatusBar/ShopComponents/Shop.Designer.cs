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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.productName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.inventoryNumber = new System.Windows.Forms.TextBox();
            this.По_быстромуShop = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.названиеТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диапазонЦенТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНесколькимКритериямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеПроизводстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.странаПроизодителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.названиеТовараToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.названиеТовараToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.типТовараToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.диапазонЦенТовараToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поНесколькимКритериямToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.поДатеПоступленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.странаПроизодителяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.названиеТовараToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ection = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productAmount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(44, 127);
            this.productName.Multiline = true;
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(156, 71);
            this.productName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название товара";
            // 
            // inventoryNumberText
            // 
            this.inventoryNumberText.AutoSize = true;
            this.inventoryNumberText.Location = new System.Drawing.Point(265, 127);
            this.inventoryNumberText.Name = "inventoryNumberText";
            this.inventoryNumberText.Size = new System.Drawing.Size(141, 16);
            this.inventoryNumberText.TabIndex = 5;
            this.inventoryNumberText.Text = "Инвентарный номер";
            // 
            // radioLittleSize
            // 
            this.radioLittleSize.AutoSize = true;
            this.radioLittleSize.Location = new System.Drawing.Point(458, 141);
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
            this.radioMediumSize.Location = new System.Drawing.Point(458, 167);
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
            this.radioBigSize.Location = new System.Drawing.Point(458, 193);
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
            this.label3.Location = new System.Drawing.Point(455, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Размер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 228);
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
            this.productType.Location = new System.Drawing.Point(44, 247);
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
            this.productWeight.Location = new System.Drawing.Point(268, 247);
            this.productWeight.Name = "productWeight";
            this.productWeight.Size = new System.Drawing.Size(120, 72);
            this.productWeight.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Вес";
            // 
            // receiptDate
            // 
            this.receiptDate.Location = new System.Drawing.Point(439, 266);
            this.receiptDate.MaxDate = new System.DateTime(2023, 12, 25, 23, 59, 59, 0);
            this.receiptDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.receiptDate.Name = "receiptDate";
            this.receiptDate.Size = new System.Drawing.Size(200, 22);
            this.receiptDate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата поступления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Кол-во";
            // 
            // productAmount
            // 
            this.productAmount.Location = new System.Drawing.Point(44, 373);
            this.productAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productAmount.Name = "productAmount";
            this.productAmount.Size = new System.Drawing.Size(120, 22);
            this.productAmount.TabIndex = 16;
            this.productAmount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(268, 372);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(100, 22);
            this.productPrice.TabIndex = 18;
            this.productPrice.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Цена(BYN)";
            // 
            // toProducer
            // 
            this.toProducer.Location = new System.Drawing.Point(283, 442);
            this.toProducer.Name = "toProducer";
            this.toProducer.Size = new System.Drawing.Size(135, 46);
            this.toProducer.TabIndex = 20;
            this.toProducer.Text = "Производитель";
            this.toProducer.UseVisualStyleBackColor = true;
            this.toProducer.Click += new System.EventHandler(this.toProducer_Click);
            // 
            // addToStore
            // 
            this.addToStore.Location = new System.Drawing.Point(420, 348);
            this.addToStore.Name = "addToStore";
            this.addToStore.Size = new System.Drawing.Size(123, 46);
            this.addToStore.TabIndex = 21;
            this.addToStore.Text = "Добавить на склад";
            this.addToStore.UseVisualStyleBackColor = true;
            this.addToStore.Click += new System.EventHandler(this.addToStore_Click);
            // 
            // showStore
            // 
            this.showStore.Location = new System.Drawing.Point(577, 349);
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
            this.StoreKeeperName.Location = new System.Drawing.Point(554, 118);
            this.StoreKeeperName.Name = "StoreKeeperName";
            this.StoreKeeperName.Size = new System.Drawing.Size(146, 20);
            this.StoreKeeperName.TabIndex = 23;
            this.StoreKeeperName.Text = "StoreKeeperName";
            // 
            // inventoryNumber
            // 
            this.inventoryNumber.Location = new System.Drawing.Point(283, 147);
            this.inventoryNumber.Name = "inventoryNumber";
            this.inventoryNumber.Size = new System.Drawing.Size(100, 22);
            this.inventoryNumber.TabIndex = 24;
            // 
            // По_быстромуShop
            // 
            this.По_быстромуShop.Location = new System.Drawing.Point(630, 147);
            this.По_быстромуShop.Name = "По_быстромуShop";
            this.По_быстромуShop.Size = new System.Drawing.Size(70, 70);
            this.По_быстромуShop.TabIndex = 25;
            this.По_быстромуShop.Text = "По-быстрому";
            this.По_быстромуShop.UseVisualStyleBackColor = true;
            this.По_быстромуShop.Click += new System.EventHandler(this.По_быстромуShop_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.названиеТовараToolStripMenuItem,
            this.типТовараToolStripMenuItem,
            this.диапазонЦенТовараToolStripMenuItem,
            this.поНесколькимКритериямToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // названиеТовараToolStripMenuItem
            // 
            this.названиеТовараToolStripMenuItem.Name = "названиеТовараToolStripMenuItem";
            this.названиеТовараToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.названиеТовараToolStripMenuItem.Text = "Название товара";
            this.названиеТовараToolStripMenuItem.Click += new System.EventHandler(this.названиеТовараToolStripMenuItem_Click);
            // 
            // типТовараToolStripMenuItem
            // 
            this.типТовараToolStripMenuItem.Name = "типТовараToolStripMenuItem";
            this.типТовараToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.типТовараToolStripMenuItem.Text = "Тип товара";
            this.типТовараToolStripMenuItem.Click += new System.EventHandler(this.типТовараToolStripMenuItem_Click);
            // 
            // диапазонЦенТовараToolStripMenuItem
            // 
            this.диапазонЦенТовараToolStripMenuItem.Name = "диапазонЦенТовараToolStripMenuItem";
            this.диапазонЦенТовараToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.диапазонЦенТовараToolStripMenuItem.Text = "Диапазон цен товара";
            this.диапазонЦенТовараToolStripMenuItem.Click += new System.EventHandler(this.диапазонЦенТовараToolStripMenuItem_Click);
            // 
            // поНесколькимКритериямToolStripMenuItem
            // 
            this.поНесколькимКритериямToolStripMenuItem.Name = "поНесколькимКритериямToolStripMenuItem";
            this.поНесколькимКритериямToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.поНесколькимКритериямToolStripMenuItem.Text = "По нескольким критериям";
            this.поНесколькимКритериямToolStripMenuItem.Click += new System.EventHandler(this.поНесколькимКритериямToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поДатеПроизводстваToolStripMenuItem,
            this.странаПроизодителяToolStripMenuItem,
            this.названиеТовараToolStripMenuItem1});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поДатеПроизводстваToolStripMenuItem
            // 
            this.поДатеПроизводстваToolStripMenuItem.Name = "поДатеПроизводстваToolStripMenuItem";
            this.поДатеПроизводстваToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.поДатеПроизводстваToolStripMenuItem.Text = "По дате поступления";
            this.поДатеПроизводстваToolStripMenuItem.Click += new System.EventHandler(this.поДатеПроизводстваToolStripMenuItem_Click);
            // 
            // странаПроизодителяToolStripMenuItem
            // 
            this.странаПроизодителяToolStripMenuItem.Name = "странаПроизодителяToolStripMenuItem";
            this.странаПроизодителяToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.странаПроизодителяToolStripMenuItem.Text = "Страна произодителя";
            this.странаПроизодителяToolStripMenuItem.Click += new System.EventHandler(this.странаПроизодителяToolStripMenuItem_Click);
            // 
            // названиеТовараToolStripMenuItem1
            // 
            this.названиеТовараToolStripMenuItem1.Name = "названиеТовараToolStripMenuItem1";
            this.названиеТовараToolStripMenuItem1.Size = new System.Drawing.Size(244, 26);
            this.названиеТовараToolStripMenuItem1.Text = "Название товара";
            this.названиеТовараToolStripMenuItem1.Click += new System.EventHandler(this.названиеТовараToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(746, 27);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.названиеТовараToolStripMenuItem2,
            this.типТовараToolStripMenuItem1,
            this.диапазонЦенТовараToolStripMenuItem1,
            this.поНесколькимКритериямToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(86, 24);
            this.toolStripDropDownButton1.Tag = "";
            this.toolStripDropDownButton1.Text = "Поиск";
            // 
            // названиеТовараToolStripMenuItem2
            // 
            this.названиеТовараToolStripMenuItem2.Name = "названиеТовараToolStripMenuItem2";
            this.названиеТовараToolStripMenuItem2.Size = new System.Drawing.Size(279, 26);
            this.названиеТовараToolStripMenuItem2.Text = "Название товара";
            this.названиеТовараToolStripMenuItem2.Click += new System.EventHandler(this.названиеТовараToolStripMenuItem2_Click);
            // 
            // типТовараToolStripMenuItem1
            // 
            this.типТовараToolStripMenuItem1.Name = "типТовараToolStripMenuItem1";
            this.типТовараToolStripMenuItem1.Size = new System.Drawing.Size(279, 26);
            this.типТовараToolStripMenuItem1.Text = "Тип товара";
            this.типТовараToolStripMenuItem1.Click += new System.EventHandler(this.типТовараToolStripMenuItem1_Click);
            // 
            // диапазонЦенТовараToolStripMenuItem1
            // 
            this.диапазонЦенТовараToolStripMenuItem1.Name = "диапазонЦенТовараToolStripMenuItem1";
            this.диапазонЦенТовараToolStripMenuItem1.Size = new System.Drawing.Size(279, 26);
            this.диапазонЦенТовараToolStripMenuItem1.Text = "Диапазон цен товара";
            this.диапазонЦенТовараToolStripMenuItem1.Click += new System.EventHandler(this.диапазонЦенТовараToolStripMenuItem1_Click);
            // 
            // поНесколькимКритериямToolStripMenuItem1
            // 
            this.поНесколькимКритериямToolStripMenuItem1.Name = "поНесколькимКритериямToolStripMenuItem1";
            this.поНесколькимКритериямToolStripMenuItem1.Size = new System.Drawing.Size(279, 26);
            this.поНесколькимКритериямToolStripMenuItem1.Text = "По нескольким критериям";
            this.поНесколькимКритериямToolStripMenuItem1.Click += new System.EventHandler(this.поНесколькимКритериямToolStripMenuItem1_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поДатеПоступленияToolStripMenuItem,
            this.странаПроизодителяToolStripMenuItem1,
            this.названиеТовараToolStripMenuItem3});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(126, 24);
            this.toolStripDropDownButton2.Text = "Сортировка";
            // 
            // поДатеПоступленияToolStripMenuItem
            // 
            this.поДатеПоступленияToolStripMenuItem.Name = "поДатеПоступленияToolStripMenuItem";
            this.поДатеПоступленияToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.поДатеПоступленияToolStripMenuItem.Text = "По дате поступления";
            this.поДатеПоступленияToolStripMenuItem.Click += new System.EventHandler(this.поДатеПоступленияToolStripMenuItem_Click);
            // 
            // странаПроизодителяToolStripMenuItem1
            // 
            this.странаПроизодителяToolStripMenuItem1.Name = "странаПроизодителяToolStripMenuItem1";
            this.странаПроизодителяToolStripMenuItem1.Size = new System.Drawing.Size(244, 26);
            this.странаПроизодителяToolStripMenuItem1.Text = "Страна произодителя";
            this.странаПроизодителяToolStripMenuItem1.Click += new System.EventHandler(this.странаПроизодителяToolStripMenuItem1_Click);
            // 
            // названиеТовараToolStripMenuItem3
            // 
            this.названиеТовараToolStripMenuItem3.Name = "названиеТовараToolStripMenuItem3";
            this.названиеТовараToolStripMenuItem3.Size = new System.Drawing.Size(244, 26);
            this.названиеТовараToolStripMenuItem3.Text = "Название товара";
            this.названиеТовараToolStripMenuItem3.Click += new System.EventHandler(this.названиеТовараToolStripMenuItem3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(103, 24);
            this.toolStripButton2.Text = "Отчистить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 24);
            this.toolStripButton1.Text = "Удалить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(75, 24);
            this.toolStripButton4.Text = "Назад";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(84, 24);
            this.toolStripButton3.Text = "Вперед";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(746, 26);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 20);
            this.toolStripStatusLabel1.Text = "Кол-во объектов:";
            // 
            // ection
            // 
            this.ection.Name = "ection";
            this.ection.Size = new System.Drawing.Size(50, 20);
            this.ection.Text = "ection";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 29;
            this.button1.Text = "Скрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Откат";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(746, 580);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.По_быстромуShop);
            this.Controls.Add(this.inventoryNumber);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Shop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.productAmount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox inventoryNumber;
        private System.Windows.Forms.Button По_быстромуShop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem названиеТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диапазонЦенТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеПроизводстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem странаПроизодителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem названиеТовараToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНесколькимКритериямToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem названиеТовараToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem типТовараToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem диапазонЦенТовараToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поНесколькимКритериямToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem поДатеПоступленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem странаПроизодителяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem названиеТовараToolStripMenuItem3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripStatusLabel ection;
    }
}