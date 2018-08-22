using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    public class Inventory
    {
        public static int pCredits = 2000;

        public static List<string> CargoSpace = new List<string>();
        //int maxCargoSize = curShipSize;
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


    }
}