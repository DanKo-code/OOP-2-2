using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form, ICalculator
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public Calculator()
        {
            InitializeComponent();
        }

        // Мышь зашла
        private void squareRootButton_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
        }
        private void cubeRootButton_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
        }

        // Мышь вышла
        private void squareRootButton_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.None;
        }
        private void cubeRootButton_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.None;
        }

        
        #region Функции интерфейса
        public void Sinus()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = inputResultField.Text;
            str = str.Replace(',', '.');

            try
            {
                inputResultField.Text = Convert.ToString(Math.Sin(Convert.ToDouble(str)));
            }
            catch
            {
                inputResultField.Text = "";
                inputResultField.BackColor = Color.Red;
                errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!");
                return;
            }
            
            
        }

        public void Cosinus()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = inputResultField.Text;
            str = str.Replace(',', '.');

            try
            {
                inputResultField.Text = Convert.ToString(Math.Cos(Convert.ToDouble(str)));
            }
            catch
            {
                inputResultField.Text = "";
                inputResultField.BackColor = Color.Red;
                errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!");
                return;
            }
            
        }

        public void Tangens()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = inputResultField.Text;
            str = str.Replace(',', '.');

            try
            {
                inputResultField.Text = Convert.ToString(Math.Tan(Convert.ToDouble(str)));
            }
            catch
            {
                inputResultField.Text = "";
                inputResultField.BackColor = Color.Red;
                errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!");
                return;
            }
            
        }

        public void Cotangens()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = inputResultField.Text;
            str = str.Replace(',', '.');

            try
            {
                inputResultField.Text = Convert.ToString(1 / Math.Tan(Convert.ToDouble(str)));
            }
            catch
            {
                inputResultField.Text = "";
                inputResultField.BackColor = Color.Red;
                errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!");
                return;
            }
            
        }

        
        public void SquareRoot()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = inputResultField.Text;
            str = str.Replace(',', '.');

            double number;
            try
            {
                number = Convert.ToDouble(str);
            }
            catch { inputResultField.Text = ""; inputResultField.BackColor = Color.Red; errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!"); return; }

            if (number < 0)
            {
                inputResultField.Text = "";
                inputResultField.BackColor = Color.Red;
                errorProvider.SetError((Control)inputResultField, "Нельзя взять корень из отрицательного числа!");
                return;
            }

            inputResultField.Text = Convert.ToString(Math.Sqrt(number));
        }

        public void CubeRoot()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = inputResultField.Text;
            str = str.Replace(',', '.');

            double number;

            try
            {
                number = Convert.ToDouble(str);
            }
            catch
            {
                inputResultField.Text = ""; inputResultField.BackColor = Color.Red; errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!"); return;
            }
            
            if(number<0)
            {
                inputResultField.Text = '-' + Convert.ToString(Math.Pow(-number, (1 / 3.0)));
            }
            else
            {
                inputResultField.Text = Convert.ToString(Math.Pow(number, (1 / 3.0)));
            }
            
        }

        public void Exponentation()
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = powerNumberField.Text;
            str = str.Replace(',', '.');

            string str2 = inputResultField.Text;
            str2 = str2.Replace(",", ".");

            double power;
            try
            {
                power = Convert.ToDouble(str);
            }
            catch
            {
                powerNumberField.Text = ""; powerNumberField.BackColor = Color.Red; errorProvider.SetError((Control)powerNumberField, "Неверный формат ввода!"); return;
            }
            

            double num;
            try
            {
                num = Math.Pow(Convert.ToDouble(str2), power);
            }
            catch
            {
                inputResultField.Text = ""; inputResultField.BackColor = Color.Red; errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!"); return;
            }
            


            inputResultField.Text = Convert.ToString(num);
            powerNumberField.Text = "";
        }

        double _arithmeticBuff;
        bool _plusFlag = false;
        bool _minusFlag = false;
        bool _multiplyFlag = false;
        bool _divisionFlag = false;

        public void Plus()
        {
            if(_plusFlag || _minusFlag || _multiplyFlag || _divisionFlag)
                arithResButton_Click(arithResButton, new EventArgs());

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = inputResultField.Text;
            str = str.Replace(',', '.');

            try
            {
                _arithmeticBuff = Convert.ToDouble(str);
            }
            catch
            {
                inputResultField.Text = ""; inputResultField.BackColor = Color.Red; errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!"); return;
            }
            

            inputResultField.Text = "";
            _plusFlag = true;
        }

        public void Minus()
        {
            if (_plusFlag || _minusFlag || _multiplyFlag || _divisionFlag)
                arithResButton_Click(arithResButton, new EventArgs());

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = inputResultField.Text;
            str = str.Replace(',', '.');

            try
            {
                _arithmeticBuff = Convert.ToDouble(str);
            }
            catch
            {
                inputResultField.Text = ""; inputResultField.BackColor = Color.Red; errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!"); return;
            }
            

            inputResultField.Text = "";
            _minusFlag = true;
        }

        public void Multiply()
        {
            if (_plusFlag || _minusFlag || _multiplyFlag || _divisionFlag)
                arithResButton_Click(arithResButton, new EventArgs());

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = inputResultField.Text;
            str = str.Replace(',', '.');

            try
            {
                _arithmeticBuff = Convert.ToDouble(str);
            }
            catch
            {
                inputResultField.Text = ""; inputResultField.BackColor = Color.Red; errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!"); return;
            }
            

            inputResultField.Text = "";
            _multiplyFlag = true;
        }

        public void Division()
        {
            if (_plusFlag || _minusFlag || _multiplyFlag || _divisionFlag)
                arithResButton_Click(arithResButton, new EventArgs());

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = inputResultField.Text;
            str = str.Replace(',', '.');

            try
            {
                _arithmeticBuff = Convert.ToDouble(str);
            }
            catch
            {
                inputResultField.Text = ""; inputResultField.BackColor = Color.Red; errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!"); return;
            }
            

            inputResultField.Text = "";
            _divisionFlag = true;
        }

        public void Clear()
        {
            inputResultField.Text = "";
        }

        double calcMemory = 0;

        public void Save()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = inputResultField.Text;
            str = str.Replace(',', '.');

            try
            {
                calcMemory = Convert.ToDouble(str);
            }
            catch
            {
                inputResultField.Text = ""; inputResultField.BackColor = Color.Red; errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!"); return;
            }
            
        }

        public void LOAD()
        {
            inputResultField.Text = Convert.ToString(calcMemory);
        }
        
        #endregion

        // Клик по кнопкам
        private void sinButton_Click(object sender, EventArgs e)
        {
            Sinus();
        }

        private void cosButton_Click(object sender, EventArgs e)
        {
            Cosinus();
        }

        private void tgButton_Click(object sender, EventArgs e)
        {
            Tangens();
        }

        private void ctgButton_Click(object sender, EventArgs e)
        {
            Cotangens();
        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {
            SquareRoot();
        }

        private void cubeRootButton_Click(object sender, EventArgs e)
        {
            CubeRoot();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            Exponentation();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            Plus();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            Minus();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            Division();
        }

        // Обработка =
        private void arithResButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = inputResultField.Text;
            str = str.Replace(',', '.');

            try
            {
                if (_plusFlag)
                {
                    inputResultField.Text = Convert.ToString(_arithmeticBuff += Convert.ToDouble(str));
                    _plusFlag = false;
                }

                else if (_minusFlag)
                {
                    inputResultField.Text = Convert.ToString(_arithmeticBuff -= Convert.ToDouble(str));
                    _minusFlag = false;
                }

                else if (_multiplyFlag)
                {
                    inputResultField.Text = Convert.ToString(_arithmeticBuff *= Convert.ToDouble(str));
                    _multiplyFlag = false;
                }

                else if (_divisionFlag)
                {
                    double number = Convert.ToDouble(str);

                    if (number == 0)
                    {
                        inputResultField.Text = "";
                        inputResultField.BackColor = Color.Red;
                        errorProvider.SetError((Control)inputResultField, "Нельзя делить на ноль!");
                        return;
                    }


                    inputResultField.Text = Convert.ToString(_arithmeticBuff /= number);
                    _divisionFlag = false;
                }
            }
            catch
            {
                inputResultField.Text = ""; inputResultField.BackColor = Color.Red; errorProvider.SetError((Control)inputResultField, "Неверный формат ввода!"); return;
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LOAD();
        }

        private void inputResultField_Click(object sender, EventArgs e)
        {
            inputResultField.BackColor = Color.White;
            powerNumberField.BackColor = Color.White;
            errorProvider.Clear();
        }

        private void powerNumberField_Click(object sender, EventArgs e)
        {
            powerNumberField.BackColor = Color.White;
            powerNumberField.BackColor = Color.White;
            errorProvider.Clear();
        }
    }

    
}
