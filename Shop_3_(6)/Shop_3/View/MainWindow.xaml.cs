﻿using Shop_3.Model;
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
        public MainWindow()
        {
            InitializeComponent();

            var sri = Application.GetResourceStream(new Uri("my-mouse-pointer.cur", UriKind.Relative));
            var customCursor = new Cursor(sri.Stream);
            Cursor = customCursor;

            DataContext = new ApplicationViewModel(new DefaultDialogService(), new JsonFileService());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("./Resources/WhiteTheme.xaml", UriKind.Relative);
            var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("./Resources/DarkTheme.xaml", UriKind.Relative);
            var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        static int counter = 0;
        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"{counter++} \n" +
                $"sender: {sender}\n" +
                $"source: {e.Source}");
        }

        private void Control_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"{counter++} \n" +
                $"sender: {sender}\n" +
                $"source: {e.Source}");
        }

        private void Message_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("RoutedUICommand");
        }
    }

    public class WindowCommand
    {
        static WindowCommand()
        {
            RUC = new RoutedCommand("RUC", typeof(MainWindow));
        }

        public static RoutedCommand RUC { get; set; }
    }

}
