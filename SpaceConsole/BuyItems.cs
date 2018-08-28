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

            
            switch (input.ToLower())
            {                    
                    case "water":
                    int water;
                    Console.WriteLine("\nHow much water would you like to buy?\n");
                    string w = Console.ReadLine();
                    water = int.Parse(w);                    
                    break;
                case "food":
                    int food;
                    Console.WriteLine("\nHow much Food would you like to buy?\n");
                    string f = Console.ReadLine();
                    food = int.Parse(f);
                    break;
                case "fuel":
                    int fuel;
                    Console.WriteLine("\nHow much Fuel would you like to buy?\n");
                    string fl = Console.ReadLine();
                    fuel = int.Parse(fl);
                    break;
                case "common mineral":
                    int commonMineral;
                    Console.WriteLine("\nHow much Common Mineral would you like to buy?\n");
                    string cm = Console.ReadLine();
                    commonMineral = int.Parse(cm);
                    break;
                case "medical supplies":
                    int medicalSupplies;
                    Console.WriteLine("\nHow much Medical Supplies would you like to buy?\n");
                    string ms = Console.ReadLine();
                    medicalSupplies = int.Parse(ms);
                    break;
                case "technology":
                    int technology;
                    Console.WriteLine("\nHow much Technology would you like to buy?\n");
                    string t = Console.ReadLine();
                    technology = int.Parse(t);                    
                    break;
                case "weapons":
                    int weapons;
                    Console.WriteLine("\nHow many Weapons would you like to buy?\n");
                    string we = Console.ReadLine();
                    weapons = int.Parse(we);
                    break;
                case "rare material":
                    int rareMaterial;
                    Console.WriteLine("\nHow much Rare Material would you like to buy?\n");
                    string rm = Console.ReadLine();
                    rareMaterial = int.Parse(rm);
                    break;
                case "dark matter":
                    int darkMatter;
                    Console.WriteLine("\nHow much Dark Matter would you like to buy?\n");
                    string dm = Console.ReadLine();
                    darkMatter = int.Parse(dm);
                    break;
                case "leave":
                    PlanetTP.Leave();
                    break;
                default:
                    Console.WriteLine("\nYou have enter an invaild item, please check your itema and try again.\n");
                    break;
            }
            // take user input on how much they want and multiply it by that item price
            // take the over all price of the above and make sure user has enough to pay
            // is user does not have enough to money, tell user and return to how much they want to buy
        }                
    }
}
