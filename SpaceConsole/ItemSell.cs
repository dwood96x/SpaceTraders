using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class ItemSell
    {
        public string ItemName;
        public int ItemPrice;
        public ItemSell(string itemName, int itemPrice)
        {
            ItemSell Water = new ItemSell("Water", 1000);
            ItemSell Food = new ItemSell("Food", 1200);
            ItemSell commonMineral = new ItemSell("Common Mineral", 5000);
            ItemSell medicalSupplies = new ItemSell("Medical Supplies", 10000);
            ItemSell technology = new ItemSell("Technology", 15000);
            ItemSell weapon = new ItemSell("Weapon", 20000);
            ItemSell rareMaterial = new ItemSell("Rare Material", 75000);
            ItemSell darkMatter = new ItemSell("Dark Matter", 1000000);
        }
    }
}
