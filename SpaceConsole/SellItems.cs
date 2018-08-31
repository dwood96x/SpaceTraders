using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class SellItems
    {
        public static void SItems(Inventory inventory, string biome)
        {
            double earthmod = 1;
            double marsmod = 1;
            double miningmod = 1;
            if (biome == "Earthish")
            {
                earthmod = 0.65;
                marsmod = 1.3;
                miningmod = 1.4;
            }
            else if (biome == "Marish")
            {
                earthmod = 1.4;
                marsmod = 0.65;
                miningmod = 1.2;
            }
            else if (biome == "Mining")
            {
                earthmod = 1.4;
                marsmod = 1.1;
                miningmod = 0.65;
            }
            double water = 900;
            double food = 1000;
            double commonMineral = 4500;
            double medicalSupplies = 9000;
            double technology = 13500;
            double weapon = 18000;
            double rareMaterial = 70000;
            double darkMatter = 92000;

            Console.Clear();
            Console.WriteLine("Which item would you like to sell {0}?\n", inventory.userName);
            Console.WriteLine("==============================================");
            Console.WriteLine("\n\t Water -                     {0}c", (water * earthmod) +
                              "\n\t Food -                      {0}c", (food * earthmod) +
                              "\n\t Common Mineral -            {0}c", (commonMineral * miningmod) +
                              "\n\t Medical Supplies -          {0}c", (medicalSupplies * earthmod) +
                              "\n\t Technology -                {0}c", (technology * marsmod) +
                              "\n\t Weapon -                    {0}c", (weapon * earthmod) +
                              "\n\t Rare Material -             {0}c", (rareMaterial * miningmod) +
                              "\n\t Dark Matter -               {0}c", (darkMatter * miningmod) +
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
