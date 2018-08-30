using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class ItemBuy
    {
        public string ItemName;
        public int ItemPrice;
        public ItemBuy(string itemName, int itemPrice)
        {
            ItemBuy Water = new ItemBuy("Water", 1000);
            ItemBuy Food = new ItemBuy("Food", 1200);
            ItemBuy commonMineral = new ItemBuy("Common Mineral", 5000);
            ItemBuy medicalSupplies = new ItemBuy("Medical Supplies", 10000);
            ItemBuy technology = new ItemBuy("Technology", 15000);
            ItemBuy weapon = new ItemBuy("Weapon", 20000);
            ItemBuy rareMaterial = new ItemBuy("Rare Material", 75000);
            ItemBuy darkMatter = new ItemBuy("Dark Matter", 1000000);
        }
    }
}
