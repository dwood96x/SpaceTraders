using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Upgrades
    {
        public void BuyUpgrade(Inventory inventory)
        {

            Console.Clear();
            Console.WriteLine("Which item would you like to buy {0}?", inventory.userName);
            Console.WriteLine("==============================================");
            Console.WriteLine("");
        }
    }
}
