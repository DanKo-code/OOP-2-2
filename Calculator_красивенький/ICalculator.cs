using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ICalculator
    {
        void Sinus();
        void Cosinus();
        void Tangens();
        void Cotangens();

        void SquareRoot();
        void CubeRoot();
        void Exponentation();

        void Plus();
        void Minus();
        void Multiply();
        void Division();

        void Clear();

        void Save();
        void LOAD();
    }
}
