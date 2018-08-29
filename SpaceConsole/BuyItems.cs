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
            Console.WriteLine("Which item would you like to buy {0}?\n", Inventory.userName);
            Console.WriteLine("==============================================");
            Console.WriteLine("\n\t Water -                     1000c" +
                              "\n\t Food -                      1200c" +                              
                              "\n\t Common Mineral -            5000c" +
                              "\n\t Medical Supplies -         10000c" +
                              "\n\t Technology -               15000c" +
                              "\n\t Weapon -                   20000c" +
                              "\n\t Rare Material -            75000c" +
                              "\n\t Dark Matter -             100000c" +
                              "\n" +
                              "\n\t Leave\n");
            Console.WriteLine("==============================================");
            string input = Console.ReadLine();

            if (input.ToLower() == "water")
            {
                int water;
                Console.Write("How much Water would you like to buy?\n");
                string wat = Console.ReadLine();
                water = int.Parse(wat);
                int total = water * 1000;
                if (total > Inventory.pCredits || Inventory.maxCargoSize < water)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = Inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Water for {1}.", wat, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    Inventory.pCredits = remain;
                    for (int i = 0; i < water; i++)
                    {
                        Inventory.AddCargo("Water");
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else if (input.ToLower() == "food")
            {
                int food;
                Console.Write("How much Water would you like to buy?\n");
                string foo = Console.ReadLine();
                food = int.Parse(foo);
                int total = food * 1200;
                if (total > Inventory.pCredits || Inventory.maxCargoSize < food)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = Inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Water for {1}.", foo, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    Inventory.pCredits = remain;
                    for (int i = 0; i < food; i++)
                    {
                        Inventory.AddCargo("Food");
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else if (input.ToLower() == "common mineral")
            {
                int commonMineral;
                Console.Write("How much Water would you like to buy?\n");
                string cm = Console.ReadLine();
                commonMineral = int.Parse(cm);
                int total = commonMineral * 5000;
                if (total > Inventory.pCredits || Inventory.maxCargoSize < commonMineral)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = Inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Common Mineral(s) for {1}.", cm, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    Inventory.pCredits = remain;
                    for (int i = 0; i < commonMineral; i++)
                    {
                        Inventory.AddCargo("Common Mineral");
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else if (input.ToLower() == "medical supply")
            {
                int medicalSupply;
                Console.Write("How much Water would you like to buy?\n");
                string ms = Console.ReadLine();
                medicalSupply = int.Parse(ms);
                int total = medicalSupply * 10000;
                if (total > Inventory.pCredits || Inventory.maxCargoSize < medicalSupply)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = Inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Medical Supply(ies) for {1}.", ms, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    Inventory.pCredits = remain;
                    for (int i = 0; i < medicalSupply; i++)
                    {
                        Inventory.AddCargo("Food");
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else if (input.ToLower() == "technology")
            {
                int technology;
                Console.Write("How much Water would you like to buy?\n");
                string tech = Console.ReadLine();
                technology = int.Parse(tech);
                int total = technology * 15000;
                if (total > Inventory.pCredits || Inventory.maxCargoSize < technology)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = Inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Technology(ies) for {1}.", tech, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    Inventory.pCredits = remain;
                    for (int i = 0; i < technology; i++)
                    {
                        Inventory.AddCargo("Technology");
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else if (input.ToLower() == "weapon")
            {
                int weapon;
                Console.Write("How much Water would you like to buy?\n");
                string weap = Console.ReadLine();
                weapon = int.Parse(weap);
                int total = weapon * 20000;
                if (total > Inventory.pCredits || Inventory.maxCargoSize < weapon)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = Inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Weapons(s)" +
                        " for {1}.", weap, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    Inventory.pCredits = remain;
                    for (int i = 0; i < weapon; i++)
                    {
                        Inventory.AddCargo("Weapon");
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else if (input.ToLower() == "rare material")
            {
                int rareMaterial;
                Console.Write("How much Water would you like to buy?\n");
                string rare = Console.ReadLine();
                rareMaterial = int.Parse(rare);
                int total = rareMaterial * 75000;
                if (total > Inventory.pCredits || Inventory.maxCargoSize < rareMaterial)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = Inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Rare Material(s)" +
                        " for {1}.", rare, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    Inventory.pCredits = remain;
                    for (int i = 0; i < rareMaterial; i++)
                    {
                        Inventory.AddCargo("Rare Material");
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else if (input.ToLower() == "food")
            {
                int darkMatter;
                Console.Write("How much Water would you like to buy?\n");
                string dark = Console.ReadLine();
                darkMatter = int.Parse(dark);
                int total = darkMatter * 100000;
                if (total > Inventory.pCredits || Inventory.maxCargoSize < darkMatter)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = Inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Dark Matter for {1}.", dark, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    Inventory.pCredits = remain;
                    for (int i = 0; i < darkMatter; i++)
                    {
                        Inventory.AddCargo("Dark Matter");
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else
            {
                Console.WriteLine("Invalid selection, please try again.\n");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }            
        }        
    }
}
