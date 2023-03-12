using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Winf_FillingObject_File_ShittyValidation
{
    public class BackForth
    {
        List<List<ShopTemplate>> history;
        Shop _shop;

        // В самом начале указывал на 0 индекс
        int current = -1;
        bool ectionFlag;

        public BackForth(Shop shop)
        {
            _shop = shop;

            history = new List<List<ShopTemplate>>();

            ectionFlag = false;
        }

        public void Add()
        {
            if(!ectionFlag)
            {
                ++current;
            }    
            history.Add(_shop.ModifideBufferShopTemplates.ToList<ShopTemplate>());
        }


        public void Back()
        {
            if(current == 0)
            {
                SystemSounds.Beep.Play();
                return;
            }


            _shop.ModifideBufferShopTemplates = history[--current];
            ectionFlag = true;
        }

        public void Forth()
        {
            if (current == history.Count - 1)
            {
                SystemSounds.Beep.Play();
                return;
            }

            _shop.ModifideBufferShopTemplates = history[++current];
            ectionFlag = true;
        }
    }
}
