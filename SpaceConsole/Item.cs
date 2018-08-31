using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Item
    {
        public string ItemName;
        public int ItemPrice;
        public Item(string itemname, int itemprice)
        {
            ItemName = itemname;
            ItemPrice = itemprice;
        }
    }
}
