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
            double tw;
            double tf;
            double tc;
            double tsm;
            double tt;
            double twe;
            double trm;
            double tdm;
            double tfuel;
            if (biome == "Earthish")
            {
                earthmod = 0.65;
                marsmod = 1.3;
                miningmod = 1.4;
            }
            else if(biome == "Marsish")
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
            Item Water = new Item("Water", 1000);
            Item Food = new Item("Food", 1200);
            Item commonMineral = new Item("Common Mineral", 5000);
            Item medicalSupplies = new Item("Medical Supplies", 10000);
            Item technology = new Item("Technology", 15000);
            Item weapon = new Item("Weapon", 20000);
            Item rareMaterial = new Item("Rare Material", 75000);
            Item darkMatter = new Item("Dark Matter", 1000000);

            Console.Clear();
            Console.WriteLine("Which item would you like to buy {0}?", inventory.userName);
            Console.WriteLine("==============================================");
            Console.WriteLine("\n\t Water -                       {0}", (tw = Water.ItemPrice * earthmod));
            Console.WriteLine("\t Food -                        {0}", (tf = Food.ItemPrice * earthmod));
            Console.WriteLine("\t Common Mineral -              {0}", (tc = commonMineral.ItemPrice * miningmod));
            Console.WriteLine("\t Medical Supplies -            {0}", (tsm = medicalSupplies.ItemPrice * earthmod));
            Console.WriteLine("\t Technology -                  {0}", (tt = technology.ItemPrice * marsmod));
            Console.WriteLine("\t Weapon -                      {0}", (twe = weapon.ItemPrice * marsmod));
            Console.WriteLine("\t Rare Material -               {0}", (trm = rareMaterial.ItemPrice * miningmod));
            Console.WriteLine("\t Dark Matter -                 {0}", (tdm = darkMatter.ItemPrice * miningmod));
            Console.WriteLine("\t Fuel -                        {0}", (tfuel = 30 * miningmod));
            Console.WriteLine("\n"); 
            Console.WriteLine("\n\t Leave\n");
            Console.WriteLine("==============================================");
            string input = Console.ReadLine();

            if (input.ToLower() == "water")
            {
                double num;
                Console.Write("How much Water would you like to buy?\n");
                string wat = Console.ReadLine();
                num = double.Parse(wat);
                double total = num * tw;
                if (total > inventory.pCredits || Ship.CurShipSize < num)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} {1} for {2}.", num, input, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = (int)remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.AddCargo("Water", Ship);
                    }
                    Console.WriteLine("Press ENTER to continiue");
                    Console.ReadLine();

                }
            }            
            else if (input.ToLower() == "food")
            {
                double num;
                Console.Write("How much Food would you like to buy?\n");
                string foo = Console.ReadLine();
                num = int.Parse(foo);
                double total = num * tf;
                if (total > inventory.pCredits || Ship.CurShipSize < num)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Food for {1}.", foo, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = (int)remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.AddCargo("Food", Ship);
                    }
                    Console.WriteLine("Press ENTER to continiue");
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "common mineral")
            {
                double num;
                Console.Write("How much Common mineral would you like to buy?\n");
                string common = Console.ReadLine();
                num = double.Parse(common);
                double total = num * tc;
                if (total > inventory.pCredits || Ship.CurShipSize < num)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Common Mineral(s) for {1}.", num, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = (int)remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.AddCargo("Common Mineral", Ship);
                    }
                    Console.WriteLine("Press ENTER to continiue");
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "medical supply")
            {
                double num;
                Console.Write("How much Medical Supply would you like to buy?\n");
                string ms = Console.ReadLine();
                num = double.Parse(ms);
                double total = num * tsm;
                if (total > inventory.pCredits || Ship.CurShipSize < num)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Medical Supply(ies) for {1}.", ms, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = (int)remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.AddCargo("Medical Supply", Ship);
                    }
                    Console.WriteLine("Press ENTER to continiue");
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "technology")
            {
                double num;
                Console.Write("How much Technology would you like to buy?\n");
                string tech = Console.ReadLine();
                num = double.Parse(tech);
                double total = num * tt;
                if (total > inventory.pCredits || Ship.CurShipSize < num)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Technology(ies) for {1}.", tech, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = (int)remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.AddCargo("Technology", Ship);
                    }
                    Console.WriteLine("Press ENTER to continiue");
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "weapon")
            {
                double num;
                Console.Write("How many Weapons would you like to buy?\n");
                string weap = Console.ReadLine();
                num = int.Parse(weap);
                double total = num * twe;
                if (total > inventory.pCredits || Ship.CurShipSize < num)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Weapons(s)" +
                        " for {1}.", weap, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = (int)remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.AddCargo("Weapon", Ship);
                    }
                    Console.WriteLine("Press ENTER to continiue");
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "rare material")
            {
                double num;
                Console.Write("How much Rare material would you like to buy?\n");
                string rare = Console.ReadLine();
                num = double.Parse(rare);
                double total = num * trm;
                if (total > inventory.pCredits || Ship.CurShipSize < num)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Rare Material(s) for {1}.", rare, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = (int)remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.AddCargo("Rare Material", Ship);
                    }
                    Console.WriteLine("Press ENTER to continiue");
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "dark matter")
            {
                double num;
                Console.Write("How much Dark Matter would you like to buy?\n");
                string dark = Console.ReadLine();
                num = int.Parse(dark);
                double total = num * tdm;
                if (total > inventory.pCredits || Ship.CurShipSize < num)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Dark Matter for {1}.", dark, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = (int)remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.AddCargo("Dark Matter", Ship);
                    }
                    Console.WriteLine("Press ENTER to continiue");
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "fuel")
            {
                Console.WriteLine("How much fuel would you like to buy?");
                string fuel = Console.ReadLine();
                double num = double.Parse(fuel);
                double total = num * tfuel;
                double tempfuel = Ship.CurrentFuel;
                if ((tempfuel += num) > Ship.MaxFuel || total > inventory.pCredits)
                {
                    Console.WriteLine("You do not have enough credits or you don't have the max fuel capacity to buy this");
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Fuel for {1}.", fuel, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = (int)remain;
                    Ship.CurrentFuel += num;
                    Console.WriteLine("Press ENTER to continiue");
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
