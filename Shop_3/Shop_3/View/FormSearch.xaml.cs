using Shop_3.ViewModel;
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

namespace Shop_3.View
{
    /// <summary>
    /// Interaction logic for FormSearch.xaml
    /// </summary>
    public partial class FormSearch : Window
    {
        ApplicationViewModel _temp;

        public FormSearch(ApplicationViewModel applicationViewModel)
        {

            InitializeComponent();

            _temp = applicationViewModel;

            DataContext = _temp;

            SearchActiveButton.DataContext = _temp;

            prod_list.DataContext = _temp;
        }
    }
}
