using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab8_SQL
{
    /// <summary>
    /// Логика взаимодействия для SortForm.xaml
    /// </summary>
    public partial class SortForm : Window
    {
        MainWindow mv;

        public SortForm(MainWindow mv)
        {
            this.mv = mv;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(SortItem.Text.Length != 0)
            {
                string sqlExpression = $"SELECT * FROM clients order by {SortItem.Text}";

                ShowForm showForm = new ShowForm(mv,sqlExpression);
                showForm.Show();
            }
        }
    }
}
