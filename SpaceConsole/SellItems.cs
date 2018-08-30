using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class SellItems
    {
        public static void SItems(Inventory inventory)
        {
            Console.Clear();
            Console.WriteLine("Which item would you like to sell {0}? Please select using intergers only!\n", inventory.userName);
            Console.WriteLine("==================================");
            Console.WriteLine("\n\t1 Water\n\t2 Food\n\t3 Fuel" +
                              "\n\t4 Common Mineral\n\t5 Medical Supplies\n\t6 Technology" +
                              "\n\t7 Weapons\n\t8 Rare Material\n\t9 Dark Matter\n" +
                              "\n\t0 I do not want to sell anything!!!");
            Console.WriteLine("==================================");
            //need to add a selection here
        }
    }
}
