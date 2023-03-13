using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Shop_3.Model
{
    public class Product : DependencyObject, INotifyPropertyChanged 
    {
        private string shortTitle;
        private string fullTitle;
        private string description;
        private string category;
        private BitmapImage image;
        private int rating;
        private int price;
        private int amount;

        public static readonly DependencyProperty PriceProperty;

        static Product()
        {

            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);

            PriceProperty = DependencyProperty.Register("Price", typeof(int), typeof(Product), metadata,
                new ValidateValueCallback(ValidateValue));
        }
        

        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 1000)  // если больше 1000, возвращаем 1000
                return 1000;
            return currentValue; // иначе возвращаем текущее значение
        }

        private static bool ValidateValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue >= 0) // если текущее значение от нуля и выше
                return true;
            return false;
        }


        public string ShortTitle
        {
            get { return shortTitle; }
            set
            {
                shortTitle = value;
                OnPropertyChanged("ShortTitle");
            }
        }

        public string FullTitle
        {
            get { return fullTitle; }
            set
            {
                fullTitle = value;
                OnPropertyChanged("FullTitle");
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                OnPropertyChanged("Category");
            }
        }

        public BitmapImage Image
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged("Image");
            }
        }

        public int Rating
        {
            get { return rating; }
            set
            {
                rating = value;
                OnPropertyChanged("Rating");
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public int Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                OnPropertyChanged("Amount");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
