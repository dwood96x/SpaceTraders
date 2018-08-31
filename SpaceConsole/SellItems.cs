using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class SellItems
    {
        public static void SItems(Inventory inventory, Ship Ship, string biome)
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
            Item Water = new Item("Water", 900);
            Item Food = new Item("Food", 1100);
            Item commonMineral = new Item("Common Mineral", 4500);
            Item medicalSupplies = new Item("Medical Supplies", 9000);
            Item technology = new Item("Technology", 13500);
            Item weapon = new Item("Weapon", 18000);
            Item rareMaterial = new Item("Rare Material", 70000);
            Item darkMatter = new Item("Dark Matter", 92500);

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

            //if (input.ToLower() == "water")
            //{
            //    double num;
            //    Console.Write("How much {0} would you like to sell?\n", input);
            //    string wat = Console.ReadLine();
            //    num = double.Parse(wat);
            //    double total = num * tw;
            //    if (num > )
            //    {
            //        Console.WriteLine("You do that much in your cargo, please check you inventory.");
            //        return;
            //    }
            //    else
            //    {
            //        double remain = inventory.pCredits - total;
            //        Console.WriteLine("\nYou bought {0} {1} for {2}.", num, input, total);
            //        Console.WriteLine("\nYou have {0} credits left.", remain);
            //        //inventory.pCredits = remain;
            //        for (int i = 0; i < num; i++)
            //        {
            //            Inventory.AddCargo("Water", Ship);
            //        }
            //        Console.ReadLine();
            //    }
            //}
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
