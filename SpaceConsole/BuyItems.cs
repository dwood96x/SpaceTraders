using System;
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
            Console.WriteLine("Which item would you like to buy {0}?\n", Inventory.userName);
            Console.WriteLine("=========================================");
            Console.WriteLine("\n\t Water -                     1000c" +
                              "\n\t Food -                      1200c" +
                              "\n\t Fuel -                      2000c" +
                              "\n\t Common Mineral -            5000c" +
                              "\n\t Medical Supplies -         10000c" +
                              "\n\t Technology -               15000c" +
                              "\n\t Weapons -                  20000c" +
                              "\n\t Rare Material -            75000c" +
                              "\n\t Dark Matter -             100000c" +
                              "\n" +
                              "\n\t Leave\n");
            Console.WriteLine("=========================================");
            string input = Console.ReadLine();

            switch (input)
            {
                case "water":
                    Console.WriteLine("\nHow much water would you like to buy?\n");
                    string water = Console.ReadLine();
                    int a = Convert.ToInt32(water);
                    break;
                case "food":
                    Console.WriteLine("\nHow much Food would you like to buy?\n");
                    string food = Console.ReadLine();
                    break;
                case "fuel":
                    Console.WriteLine("\nHow much Fuel would you like to buy?\n");
                    string fuel = Console.ReadLine();
                    break;
                case "common mineral":
                    Console.WriteLine("\nHow much Common Mineral would you like to buy?\n");
                    string commonMineral = Console.ReadLine();
                    break;
                case "medical supplies":
                    Console.WriteLine("\nHow much Medical Supplies would you like to buy?\n");
                    string medicalSupplies = Console.ReadLine();
                    break;
                case "technology":
                    Console.WriteLine("\nHow much Technology would you like to buy?\n");
                    string technology = Console.ReadLine();
                    break;
                case "weapons":
                    Console.WriteLine("\nHow many Weapons would you like to buy?\n");
                    string weapons = Console.ReadLine();
                    break;
                case "rare material":
                    Console.WriteLine("\nHow much Rare Material would you like to buy?\n");
                    string rareMaterial = Console.ReadLine();
                    break;
                case "dark matter":
                    Console.WriteLine("\nHow much Dark Matter would you like to buy?\n");
                    string darkMatter = Console.ReadLine();
                    break;
                case "leave":
                    //need to get back to the current planet's options
                    break;
                default:
                    Console.WriteLine("\nYou have enter an invaild item, please check your itema and try again.\n");
                    break;
            }

        }
        public static void userInput(string input)
        {
            
        }        
    }
}
