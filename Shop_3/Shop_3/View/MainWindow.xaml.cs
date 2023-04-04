using Shop_3.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shop_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ApplicationViewModel _temp;

        public MainWindow()
        {
            InitializeComponent();

            var sri = Application.GetResourceStream(new Uri("my-mouse-pointer.cur", UriKind.Relative));
            var customCursor = new Cursor(sri.Stream);
            Cursor = customCursor;

            ApplicationViewModel temp = new ApplicationViewModel(new DefaultDialogService(), new JsonFileService());

            _temp = temp;

            DataContext = temp;


            ClearButton.DataContext = temp;
        }
    }
}

