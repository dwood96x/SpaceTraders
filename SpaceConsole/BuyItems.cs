﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class BuyItems
    {
        public static void BItems()
        {
                Console.Clear();
                Console.WriteLine("Which item would you like to buy {0}?  Please use the intergers only!\n", Inventory.userName);
                Console.WriteLine("===========================================");
                Console.WriteLine("\n\t1 Water\n\t2 Food\n\t3 Fuel" +
                                  "\n\t4 Common Mineral\n\t5 Medical Supplies\n\t6 Technology" +
                                  "\n\t7 Weapons\n\t8 Rare Material\n\t9 Dark Matter\n");
                Console.WriteLine("===========================================");          
        }
}
}
