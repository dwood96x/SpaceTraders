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
            Console.WriteLine("\n"); 
            Console.WriteLine("\n\t Leave\n");
            Console.WriteLine("==============================================");
            string input = Console.ReadLine();

            if (input.ToLower() == "water")
            {
                double num;
                Console.Write("How much {0} would you like to buy?\n", input);
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
                double fnum;
                Console.Write("How much Food would you like to buy?\n");
                string foo = Console.ReadLine();
                fnum = int.Parse(foo);
                double total = fnum * tf;
                if (total > inventory.pCredits || Ship.CurShipSize < fnum)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Water for {1}.", foo, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);                    
                    for (int i = 0; i < fnum; i++)
                    {
                        Inventory.AddCargo("Food", Ship);
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else if (input.ToLower() == "common mineral")
            {
                double cmnum;
                Console.Write("How much {0} would you like to buy?\n", input);
                string common = Console.ReadLine();
                cmnum = double.Parse(common);
                double total = cmnum * tc;
                if (total > inventory.pCredits || Ship.CurShipSize < cmnum)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Common Mineral(s) for {1}.", cmnum, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);

                    for (int i = 0; i < cmnum; i++)
                    {
                        Inventory.AddCargo("Common Mineral", Ship);
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else if (input.ToLower() == "medical supply")
            {
                double msnum;
                Console.Write("How much {0} would you like to buy?\n", input);
                string ms = Console.ReadLine();
                msnum = double.Parse(ms);
                double total = msnum * tsm;
                if (total > inventory.pCredits || Ship.CurShipSize < msnum)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Medical Supply(ies) for {1}.", ms, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);

                    for (int i = 0; i < msnum; i++)
                    {
                        Inventory.AddCargo("Medical Supply", Ship);
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else if (input.ToLower() == "technology")
            {
                double tnum;
                Console.Write("How much {0} would you like to buy?\n", input);
                string tech = Console.ReadLine();
                tnum = double.Parse(tech);
                double total = tnum * tt;
                if (total > inventory.pCredits || Ship.CurShipSize < tnum)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Technology(ies) for {1}.", tech, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);

                    for (int i = 0; i < tnum; i++)
                    {
                        Inventory.AddCargo("Technology", Ship);
                    }
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "weapon")
            {
                double wnum;
                Console.Write("How much Water would you like to buy?\n");
                string weap = Console.ReadLine();
                wnum = int.Parse(weap);
                double total = wnum * twe;
                if (total > inventory.pCredits || Ship.CurShipSize < wnum)
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

                    for (int i = 0; i < wnum; i++)
                    {
                        Inventory.AddCargo("Weapon", Ship);
                    }
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "rare material")
            {
                double rarenum;
                Console.Write("How much Water would you like to buy?\n");
                string rare = Console.ReadLine();
                rarenum = double.Parse(rare);
                double total = rarenum * trm;
                if (total > inventory.pCredits || Ship.CurShipSize < rarenum)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Rare Material(s) for {1}.", rare, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);

                    for (int i = 0; i < rarenum; i++)
                    {
                        Inventory.AddCargo("Rare Material", Ship);
                    }
                    Console.ReadLine();
                    //leave method
                }
            }
            else if (input.ToLower() == "dark matter")
            {
                double darknum;
                Console.Write("How much Dark Matter would you like to buy?\n");
                string dark = Console.ReadLine();
                darknum = int.Parse(dark);
                double total = darknum * tdm;
                if (total > inventory.pCredits || Ship.CurShipSize < darknum)
                {
                    Console.WriteLine("You do not have enough credits or you do not have enough space to buy this");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits - total;
                    Console.WriteLine("\nYou bought {0} Dark Matter for {1}.", dark, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);

                    for (int i = 0; i < darknum; i++)
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
