using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shop_3.Model
{
    public class CategoryPriceModel: INotifyPropertyChanged
    {
        private string category;
        private int startPrice;
        private int endPrice;

        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                OnPropertyChanged("Category");
            }
        }

        public int StartPrice
        {
            get { return startPrice; }
            set
            {
                startPrice = value;
                OnPropertyChanged("StartPrice");
            }
        }

        public int EndPrice
        {
            get { return endPrice; }
            set
            {
                endPrice = value;
                OnPropertyChanged("EndPrice");
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
