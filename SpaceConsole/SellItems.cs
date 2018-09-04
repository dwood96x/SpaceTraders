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
            else if (biome == "Marsish")
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
            Console.WriteLine("Which item would you like to sell {0}?", inventory.userName);
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
                Console.Write("How much Water would you like to sell?\n");
                string wat = Console.ReadLine();
                num = double.Parse(wat);
                double total = num * tw;
                if (num > Inventory.InventoryQuantities()[0])
                {
                    Console.WriteLine("You do not have that much in your cargo, please check you inventory.");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits + total;
                    Console.WriteLine("\nYou sold {0} Water(s) for {1}.", num, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.RemoveCargo("Water", Ship);
                    }
                    Console.ReadLine();
                }
                Array.Clear(Inventory.cargoQuantity, 0, 8);
            }
            else if (input.ToLower() == "food")
            {
                double num;
                Console.Write("How much Food would you like to sell?\n");
                string wat = Console.ReadLine();
                num = double.Parse(wat);
                double total = num * tw;
                if (num > Inventory.InventoryQuantities()[1])
                {
                    Console.WriteLine("You do not have that much in your cargo, please check you inventory.");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits + total;
                    Console.WriteLine("\nYou sold {0} Food for {1}.", num, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.RemoveCargo("Food", Ship);
                    }
                    Console.ReadLine();
                }
                Array.Clear(Inventory.cargoQuantity, 0, 8);
            }
            else if (input.ToLower() == "common mineral")
            {
                double num;
                Console.Write("How much Common Mineral would you like to sell?\n");
                string wat = Console.ReadLine();
                num = double.Parse(wat);
                double total = num * tw;
                if (num > Inventory.InventoryQuantities()[2])
                {
                    Console.WriteLine("You do have that much in your cargo, please check you inventory.");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits + total;
                    Console.WriteLine("\nYou sold {0} Common Mineral(s) for {1}.", num, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.RemoveCargo("Common Mineral", Ship);
                    }
                    Console.ReadLine();
                }
                Array.Clear(Inventory.cargoQuantity, 0, 8);
            }
            else if (input.ToLower() == "medical supplies")
            {
                double num;
                Console.Write("How many Medical Supplies would you like to sell?\n");
                string wat = Console.ReadLine();
                num = double.Parse(wat);
                double total = num * tw;
                if (num > Inventory.InventoryQuantities()[3])
                {
                    Console.WriteLine("You do have that much in your cargo, please check you inventory.");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits + total;
                    Console.WriteLine("\nYou sold {0} Medical Supplies for {1}.", num, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.RemoveCargo("Medical Supplies", Ship);
                    }
                    Console.ReadLine();
                }
                Array.Clear(Inventory.cargoQuantity, 0, 8);
            }
            else if (input.ToLower() == "technology")
            {
                double num;
                Console.Write("How much Technology would you like to sell?\n");
                string wat = Console.ReadLine();
                num = double.Parse(wat);
                double total = num * tw;
                if (num > Inventory.InventoryQuantities()[4])
                {
                    Console.WriteLine("You do have that much in your cargo, please check you inventory.");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits + total;
                    Console.WriteLine("\nYou sold {0} Technology for {1}.", num, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.RemoveCargo("Technology", Ship);
                    }
                    Console.ReadLine();
                }
                Array.Clear(Inventory.cargoQuantity, 0, 8);
            }
            else if (input.ToLower() == "weapon")
            {
                double num;
                Console.Write("How many Weapon(s) would you like to sell?\n");
                string wat = Console.ReadLine();
                num = double.Parse(wat);
                double total = num * tw;
                if (num > Inventory.InventoryQuantities()[5])
                {
                    Console.WriteLine("You do have that much in your cargo, please check you inventory.");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits + total;
                    Console.WriteLine("\nYou sold {0} Weapon(s) for {1}.", num, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.RemoveCargo("Weapon", Ship);
                    }
                    Console.ReadLine();
                }
                Array.Clear(Inventory.cargoQuantity, 0, 8);
            }
            else if (input.ToLower() == "rare material")
            {
                double num;
                Console.Write("How much Rare Material would you like to sell?\n");
                string wat = Console.ReadLine();
                num = double.Parse(wat);
                double total = num * tw;
                if (num > Inventory.InventoryQuantities()[6])
                {
                    Console.WriteLine("You do have that much in your cargo, please check you inventory.");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits + total;
                    Console.WriteLine("\nYou sold {0} Rare Material for {1}.", num, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.RemoveCargo("Rare Material", Ship);
                    }
                    Console.ReadLine();
                }
                Array.Clear(Inventory.cargoQuantity, 0, 8);
            }
            else if (input.ToLower() == "dark matter")
            {
                double num;
                Console.Write("How much Dark Matter would you like to sell?\n");
                string wat = Console.ReadLine();
                num = double.Parse(wat);
                double total = num * tw;
                if (num > Inventory.InventoryQuantities()[7])
                {
                    Console.WriteLine("You do have that much in your cargo, please check you inventory.");
                    return;
                }
                else
                {
                    double remain = inventory.pCredits + total;
                    Console.WriteLine("\nYou sold {0} Dark Matter for {1}.", num, total);
                    Console.WriteLine("\nYou have {0} credits left.", remain);
                    inventory.pCredits = remain;
                    for (int i = 0; i < num; i++)
                    {
                        Inventory.RemoveCargo("Dark Matter", Ship);
                    }
                    Console.ReadLine();
                }
                Array.Clear(Inventory.cargoQuantity, 0, 8);
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
