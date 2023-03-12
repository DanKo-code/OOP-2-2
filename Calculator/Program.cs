using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new Calculator());
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Некорректный ввод числа!");
            }
            catch(Exception exeption)
            {
                System.Windows.Forms.MessageBox.Show(exeption.Message);
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Завершение работы калькулятора!");
            }
        }
    }
}
