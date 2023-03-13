using Shop_3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shop_3.UndoRedo
{
    public class NHist
    {
        public Stack<Saf> Form { get; private set; }
        public NHist()
        {
            Form = new Stack<Saf>();
        }
    }
    public class Saf
    {
        public ObservableCollection<Product> list = new ObservableCollection<Product>();
        public Saf(ref ObservableCollection<Product> accounts)
        {
            foreach (Product account in accounts)
            {
                this.list.Add(account);
            }
        }
    }
}
