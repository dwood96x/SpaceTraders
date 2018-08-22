using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    public class Inventory
    {
        public static int pCredits;
        public static int age;
        public static List<string> CargoSpace = new List<string>();
        public static double maxCargoSize = Ship.curShipSize;
        public static void AddCargo(string boughtItem)
        {
            if (CargoSpace.Count == maxCargoSize)
            {
                Console.WriteLine("Your cargospace is full. Sell something or upgrade your ship to get more.");
            }
            else if (CargoSpace.Count < maxCargoSize)
            {
                Console.WriteLine("Adding {0} to your cargo.");
                CargoSpace.Add(boughtItem);
            }
        }
        public static void RemoveCargo(string removeItem)
        {
            CargoSpace.Remove(removeItem);
            Console.WriteLine("{0} removed from cargo.", removeItem);
        }

        public static void checkInventory()
        {
            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("You have {0} credits.", pCredits);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Your {0} has a max cargo space of {1}", Ship.shipName, maxCargoSize );
            Console.WriteLine("--------------------------------------");
            foreach (var a in CargoSpace)
                Console.WriteLine(a);
        }
    }
}