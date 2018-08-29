using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    public class Inventory
    {
        public static string userName;
        public static int pCredits;
        public static int age;
        public static double totalDistance;
        public static string currentPlanet;
        public static List<string> CargoSpace = new List<string>();
        public static double maxCargoSize;
        public static int totalCredits;
        public static void SetMaxCargo(Ship shipname)
        {
            maxCargoSize = shipname.CurShipSize;
        }
        public static void AddCargo(string boughtItem)
        {
            if (CargoSpace.Count == maxCargoSize)
            {
                Console.WriteLine("Your cargospace is full. Sell something or upgrade your ship to get more.");
            }
            else if (CargoSpace.Count < maxCargoSize)
            {
                Console.WriteLine("Adding {0} to your cargo.", boughtItem);
                CargoSpace.Add(boughtItem);
            }
        }
        public static void RemoveCargo(string removeItem)
        {
            CargoSpace.Remove(removeItem);
            Console.WriteLine("{0} removed from cargo.", removeItem);
        }

        public static void CheckInventory(Ship shipname)
        {
            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("You have {0} credits.", pCredits);
            Console.WriteLine("You are at {0}", currentPlanet);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Your ship is a {0} and has a max cargo space of {1}", shipname.ShipName, maxCargoSize );
            Console.WriteLine("--------------------------------------");
            foreach (var a in CargoSpace)
                Console.WriteLine(a);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}