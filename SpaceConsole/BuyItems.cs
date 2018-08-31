using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class BuyItems
    {        
        public static void BItems(Inventory inventory,Ship Ship, string biome)
        {
            double earthmod = 1;
            double marsmod = 1;
            double miningmod = 1;
            double tWater;
            if (biome == "Earthish")
            {
                earthmod = 0.65;
                marsmod = 1.3;
                miningmod = 1.4;
            }
            else if(biome == "Marish")
            {
                earthmod = 1.4;
                marsmod = 0.65;
                miningmod = 1.2;
            }
            else if(biome == "Mining")
            {
                earthmod = 1.4;
                marsmod = 1.1;
                miningmod = 0.65;
            }
            ItemBuy Water = new ItemBuy("Water", 1000);
            ItemBuy Food = new ItemBuy("Food", 1200);
            ItemBuy commonMineral = new ItemBuy("Common Mineral", 5000);
            ItemBuy medicalSupplies = new ItemBuy("Medical Supplies", 10000);
            ItemBuy technology = new ItemBuy("Technology", 15000);
            ItemBuy weapon = new ItemBuy("Weapon", 20000);
            ItemBuy rareMaterial = new ItemBuy("Rare Material", 75000);
            ItemBuy darkMatter = new ItemBuy("Dark Matter", 1000000);

            Console.Clear();
            Console.WriteLine("Which item would you like to buy {0}?\n", inventory.userName);
            Console.WriteLine("==============================================");
            Console.WriteLine("\n\t Water -                     {0}c",(tWater = Water.ItemPrice * earthmod) +
                              "\n\t Food -                      {0}c",(Food.ItemPrice * earthmod) +                              
                              "\n\t Common Mineral -            {0}c",(commonMineral.ItemPrice * miningmod) +
                              "\n\t Medical Supplies -          {0}c",(medicalSupplies.ItemPrice * earthmod) +
                              "\n\t Technology -                {0}c",(technology.ItemPrice * marsmod) +
                              "\n\t Weapon -                    {0}c",(weapon.ItemPrice * earthmod) +
                              "\n\t Rare Material -             {0}c",(rareMaterial.ItemPrice * miningmod) +
                              "\n\t Dark Matter -               {0}c",(darkMatter.ItemPrice * miningmod) +
                              "\n" +
                              "\n\t Leave\n");
            Console.WriteLine("==============================================");
            string input = Console.ReadLine();

            if (input.ToLower() == "water")
            {
                double num;
                Console.Write("How much {0} would you like to buy?\n", input);
                string wat = Console.ReadLine();
                num = double.Parse(wat);
                double total = num * tWater;
                if (total > inventory.pCredits || Ship.CurShipSize < num)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} {1} for {2}.", wat, input, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    //inventory.pCredits = remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.AddCargo("Water", Ship);
                    }
                    Console.ReadLine();                    
                }
            }
            else if (input.ToLower() == "food")
            {
                int food;
                Console.Write("How much Water would you like to buy?\n");
                string foo = Console.ReadLine();
                food = int.Parse(foo);
                int total = food * 1200;
                if (total > inventory.pCredits || Ship.CurShipSize < food)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Water for {1}.", foo, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < food; i++)
                    {
                        Inventory.AddCargo("Food", Ship);
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
                if (total > inventory.pCredits || Ship.CurShipSize < commonMineral)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Common Mineral(s) for {1}.", cm, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < commonMineral; i++)
                    {
                        Inventory.AddCargo("Common Mineral", Ship);
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
                if (total > inventory.pCredits || Ship.CurShipSize < medicalSupply)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Medical Supply(ies) for {1}.", ms, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < medicalSupply; i++)
                    {
                        Inventory.AddCargo("Food", Ship);
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
                if (total > inventory.pCredits || Ship.CurShipSize < technology)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Technology(ies) for {1}.", tech, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < technology; i++)
                    {
                        Inventory.AddCargo("Technology", Ship);
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
                if (total > inventory.pCredits || Ship.CurShipSize < weapon)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Weapons(s)" +
                        " for {1}.", weap, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < weapon; i++)
                    {
                        Inventory.AddCargo("Weapon", Ship);
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
                if (total > inventory.pCredits || Ship.CurShipSize < rareMaterial)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Rare Material(s)" +
                        " for {1}.", rare, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < rareMaterial; i++)
                    {
                        Inventory.AddCargo("Rare Material", Ship);
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else if (input.ToLower() == "dark matter")
            {
                int darkMatter;
                Console.Write("How much Dark Matter would you like to buy?\n");
                string dark = Console.ReadLine();
                darkMatter = int.Parse(dark);
                int total = darkMatter * 100000;
                if (total > inventory.pCredits || Ship.CurShipSize < darkMatter)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    int remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Dark Matter for {1}.", dark, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < darkMatter; i++)
                    {
                        Inventory.AddCargo("Dark Matter", Ship);
                    }
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "leave")
            {

            }
            else
            {
                Console.WriteLine("Invalid selection, please try again.\n");
                Console.WriteLine("Press ENTER` to continue");
                Console.ReadLine();
                Console.Clear();
            }            
        }        
    }
}
