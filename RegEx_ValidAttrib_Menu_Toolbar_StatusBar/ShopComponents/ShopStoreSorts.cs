using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winf_FillingObject_File_ShittyValidation
{
    partial class Shop
    {
        //Sorts
        private void поДатеПроизводстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifideBufferShopTemplates = ModifideBufferShopTemplates.OrderBy(x => x._date).ToList();
            PrintModifiedShopStore();
            backForth.Add();
        }

        private void странаПроизодителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifideBufferShopTemplates = ModifideBufferShopTemplates.OrderBy(x => x._producer._country).ToList();
            PrintModifiedShopStore();
            backForth.Add();
        }

        private void названиеТовараToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifideBufferShopTemplates = ModifideBufferShopTemplates.OrderBy(x => x._productName).ToList();
            PrintModifiedShopStore();
            backForth.Add();
        }
    }
}
