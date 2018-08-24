using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class BuyItems
    {
        public static string itemtoadd;
        public static void BItems()
        {
            Console.Clear();
            Console.WriteLine("Which item would you like to buy {0}?\n", Inventory.userName);
            Console.WriteLine("==================================");
            Console.WriteLine("\n\t1 Water - 1000c\n\t2 Food - 1200c\n\t3 Fuel - 2000c" +
                              "\n\t4 Common Mineral - 5000c\n\t5 Medical Supplies - 10000c\n\t6 Technology - 15000c" +
                              "\n\t7 Weapons - 20,000c\n\t8 Rare Material - 75,000c\n\t9 Dark Matter - 100,000c\n" +
                              "\n\t0 I do not want to buy anything!!!\n");
            Console.WriteLine("==================================");
            string input = Console.ReadLine();
        }    
        
    }
}
