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
            inputResultField.Text = Convert.ToString(Math.Sin(Convert.ToDouble(inputResultField.Text)));
        }

        public void Cosinus()
        {
            inputResultField.Text = Convert.ToString(Math.Cos(Convert.ToDouble(inputResultField.Text)));
        }

        public void Tangens()
        {
            inputResultField.Text = Convert.ToString(Math.Tan(Convert.ToDouble(inputResultField.Text)));
        }

        public void Cotangens()
        {
            inputResultField.Text = Convert.ToString(1 / Math.Tan(Convert.ToDouble(inputResultField.Text)));
        }

        public void SquareRoot()
        {
            double number = Convert.ToDouble(inputResultField.Text);

            if (number < 0) throw new Exception("Нельзя взять корень из отрицательного числа!");

            inputResultField.Text = Convert.ToString(Math.Sqrt(number));
        }

        public void CubeRoot()
        {
            double number = Convert.ToDouble(inputResultField.Text);

            if (number < 0) throw new Exception("Нельзя взять корень из отрицательного числа!");

            inputResultField.Text = Convert.ToString(Math.Pow( number, (1/3.0) ) );
        }

        public void Exponentation()
        {
            inputResultField.Text = Convert.ToString(Math.Pow( Convert.ToDouble(inputResultField.Text), Convert.ToDouble(powerNumberField.Text) ));
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
            {
                arithResButton_Click(arithResButton, new EventArgs());
                return;
            }    
                

            _arithmeticBuff = Convert.ToDouble(inputResultField.Text);
            inputResultField.Text = "";
            _plusFlag = true;
        }

        public void Minus()
        {
            if (_plusFlag || _minusFlag || _multiplyFlag || _divisionFlag)
            {
                arithResButton_Click(arithResButton, new EventArgs());
                return;
            }

            _arithmeticBuff = Convert.ToDouble(inputResultField.Text);
            inputResultField.Text = "";
            _minusFlag = true;
        }

        public void Multiply()
        {
            if (_plusFlag || _minusFlag || _multiplyFlag || _divisionFlag)
            {
                arithResButton_Click(arithResButton, new EventArgs());
                return;
            }

            _arithmeticBuff = Convert.ToDouble(inputResultField.Text);
            inputResultField.Text = "";
            _multiplyFlag = true;
        }

        public void Division()
        {
            if (_plusFlag || _minusFlag || _multiplyFlag || _divisionFlag)
            {
                arithResButton_Click(arithResButton, new EventArgs());
                return;
            }

            _arithmeticBuff = Convert.ToDouble(inputResultField.Text);
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
            calcMemory = Convert.ToDouble(inputResultField.Text);
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
            if(_plusFlag)
            {
                inputResultField.Text = Convert.ToString( _arithmeticBuff += Convert.ToDouble(inputResultField.Text) );
                _plusFlag = false;
            }

            else if (_minusFlag)
            {
                inputResultField.Text = Convert.ToString(_arithmeticBuff -= Convert.ToDouble(inputResultField.Text));
                _minusFlag = false;
            }

            else if (_multiplyFlag)
            {
                inputResultField.Text = Convert.ToString(_arithmeticBuff *= Convert.ToDouble(inputResultField.Text));
                _multiplyFlag = false;
            }

            else if (_divisionFlag)
            {
                double number = Convert.ToDouble(inputResultField.Text);

                if (number == 0) throw new DivideByZeroException("Нельзя делить на ноль!");

                inputResultField.Text = Convert.ToString(_arithmeticBuff /= number);
                _divisionFlag = false;
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

        
    }

    
}
