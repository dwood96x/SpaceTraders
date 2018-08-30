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
            Console.WriteLine("Which item would you like to sell {0}?\n", inventory.userName);
            Console.WriteLine("==============================================");
            Console.WriteLine("\n\t Water -                     700c" +
                              "\n\t Food -                      840c" +
                              "\n\t Common Mineral -           3500c" +
                              "\n\t Medical Supplies -         7000c" +
                              "\n\t Technology -              10500c" +
                              "\n\t Weapon -                  14000c" +
                              "\n\t Rare Material -           52500c" +
                              "\n\t Dark Matter -             70000c" +
                              "\n" +
                              "\n\t Leave\n");
            Console.WriteLine("==============================================");
            string input = Console.ReadLine();

           
            //else
            //{
            //    Console.WriteLine("Invalid selection, please try again.\n");
            //    Console.WriteLine("Press ENTER` to continue");
            //    Console.ReadLine();
            //    Console.Clear();
            //}
        }
    }
}
