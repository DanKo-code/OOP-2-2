namespace Calculator
{
    partial class Calculator
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
            this.inputResultField = new System.Windows.Forms.TextBox();
            this.sinButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.tgButton = new System.Windows.Forms.Button();
            this.ctgButton = new System.Windows.Forms.Button();
            this.cubeRootButton = new System.Windows.Forms.PictureBox();
            this.squareRootButton = new System.Windows.Forms.PictureBox();
            this.powerButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.powerNumberField = new System.Windows.Forms.TextBox();
            this.arithResButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cubeRootButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareRootButton)).BeginInit();
            this.SuspendLayout();
            // 
            // inputResultField
            // 
            this.inputResultField.Location = new System.Drawing.Point(77, 53);
            this.inputResultField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputResultField.Name = "inputResultField";
            this.inputResultField.Size = new System.Drawing.Size(316, 22);
            this.inputResultField.TabIndex = 0;
            this.inputResultField.Click += new System.EventHandler(this.inputResultField_Click);
            // 
            // sinButton
            // 
            this.sinButton.Location = new System.Drawing.Point(49, 121);
            this.sinButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(75, 23);
            this.sinButton.TabIndex = 1;
            this.sinButton.Text = "SIN";
            this.sinButton.UseVisualStyleBackColor = true;
            this.sinButton.Click += new System.EventHandler(this.sinButton_Click);
            // 
            // cosButton
            // 
            this.cosButton.Location = new System.Drawing.Point(49, 170);
            this.cosButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(75, 23);
            this.cosButton.TabIndex = 2;
            this.cosButton.Text = "COS";
            this.cosButton.UseVisualStyleBackColor = true;
            this.cosButton.Click += new System.EventHandler(this.cosButton_Click);
            // 
            // tgButton
            // 
            this.tgButton.Location = new System.Drawing.Point(49, 222);
            this.tgButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgButton.Name = "tgButton";
            this.tgButton.Size = new System.Drawing.Size(75, 23);
            this.tgButton.TabIndex = 3;
            this.tgButton.Text = "TG";
            this.tgButton.UseVisualStyleBackColor = true;
            this.tgButton.Click += new System.EventHandler(this.tgButton_Click);
            // 
            // ctgButton
            // 
            this.ctgButton.Location = new System.Drawing.Point(49, 270);
            this.ctgButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctgButton.Name = "ctgButton";
            this.ctgButton.Size = new System.Drawing.Size(75, 23);
            this.ctgButton.TabIndex = 4;
            this.ctgButton.Text = "CTG";
            this.ctgButton.UseVisualStyleBackColor = true;
            this.ctgButton.Click += new System.EventHandler(this.ctgButton_Click);
            // 
            // cubeRootButton
            // 
            this.cubeRootButton.Image = global::Calculator.Properties.Resources.кубический_корень;
            this.cubeRootButton.Location = new System.Drawing.Point(204, 194);
            this.cubeRootButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cubeRootButton.Name = "cubeRootButton";
            this.cubeRootButton.Size = new System.Drawing.Size(69, 49);
            this.cubeRootButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cubeRootButton.TabIndex = 6;
            this.cubeRootButton.TabStop = false;
            this.cubeRootButton.Click += new System.EventHandler(this.cubeRootButton_Click);
            this.cubeRootButton.MouseEnter += new System.EventHandler(this.cubeRootButton_MouseEnter);
            this.cubeRootButton.MouseLeave += new System.EventHandler(this.cubeRootButton_MouseLeave);
            // 
            // squareRootButton
            // 
            this.squareRootButton.Image = global::Calculator.Properties.Resources.квадратный_корень1;
            this.squareRootButton.Location = new System.Drawing.Point(204, 121);
            this.squareRootButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.squareRootButton.Name = "squareRootButton";
            this.squareRootButton.Size = new System.Drawing.Size(69, 49);
            this.squareRootButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.squareRootButton.TabIndex = 5;
            this.squareRootButton.TabStop = false;
            this.squareRootButton.Click += new System.EventHandler(this.squareRootButton_Click);
            this.squareRootButton.MouseEnter += new System.EventHandler(this.squareRootButton_MouseEnter);
            this.squareRootButton.MouseLeave += new System.EventHandler(this.squareRootButton_MouseLeave);
            // 
            // powerButton
            // 
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerButton.Location = new System.Drawing.Point(199, 270);
            this.powerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.powerButton.Name = "powerButton";
            this.powerButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.powerButton.Size = new System.Drawing.Size(75, 41);
            this.powerButton.TabIndex = 7;
            this.powerButton.Text = "^n";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusButton.Location = new System.Drawing.Point(349, 110);
            this.plusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 32);
            this.plusButton.TabIndex = 8;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusButton.Location = new System.Drawing.Point(349, 159);
            this.minusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(75, 32);
            this.minusButton.TabIndex = 9;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyButton.Location = new System.Drawing.Point(349, 210);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 32);
            this.multiplyButton.TabIndex = 10;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionButton.Location = new System.Drawing.Point(349, 258);
            this.divisionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(75, 32);
            this.divisionButton.TabIndex = 11;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(495, 25);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(136, 62);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(495, 154);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 62);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(495, 242);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(136, 62);
            this.loadButton.TabIndex = 14;
            this.loadButton.Text = "LOAD";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Input and Result";
            // 
            // powerNumberField
            // 
            this.powerNumberField.Location = new System.Drawing.Point(188, 318);
            this.powerNumberField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.powerNumberField.Name = "powerNumberField";
            this.powerNumberField.Size = new System.Drawing.Size(100, 22);
            this.powerNumberField.TabIndex = 16;
            this.powerNumberField.Click += new System.EventHandler(this.powerNumberField_Click);
            // 
            // arithResButton
            // 
            this.arithResButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arithResButton.Location = new System.Drawing.Point(349, 305);
            this.arithResButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arithResButton.Name = "arithResButton";
            this.arithResButton.Size = new System.Drawing.Size(75, 32);
            this.arithResButton.TabIndex = 17;
            this.arithResButton.Text = "=";
            this.arithResButton.UseVisualStyleBackColor = true;
            this.arithResButton.Click += new System.EventHandler(this.arithResButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(707, 350);
            this.Controls.Add(this.arithResButton);
            this.Controls.Add(this.powerNumberField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.cubeRootButton);
            this.Controls.Add(this.squareRootButton);
            this.Controls.Add(this.ctgButton);
            this.Controls.Add(this.tgButton);
            this.Controls.Add(this.cosButton);
            this.Controls.Add(this.sinButton);
            this.Controls.Add(this.inputResultField);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calculator";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.cubeRootButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareRootButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputResultField;
        private System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button cosButton;
        private System.Windows.Forms.Button tgButton;
        private System.Windows.Forms.Button ctgButton;
        private System.Windows.Forms.PictureBox squareRootButton;
        private System.Windows.Forms.PictureBox cubeRootButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox powerNumberField;
        private System.Windows.Forms.Button arithResButton;
    }
}

