using Shop_3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Shop_3
{
    public interface IFileService
    {
        List<Product> Open(string filename);
        void Save(string filename, List<Product> phonesList);
    }
}
