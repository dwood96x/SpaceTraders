using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class PlanetTP
    {
        

        public static void EarthTP()
        {
            Console.WriteLine("Welcome to the Trading Post of Earth.\n");
            Console.WriteLine("Here is the list of items availble.\n");
            Console.WriteLine("===========================================\n");
            Console.WriteLine("\tOption 1 - Water\n\tOption 2 - Food\n\tOption 3 - Fuel\n\tOption 4 - Common Mineral\n\tOption 5 - Medical Supplies\n" +
                              "\tOption 6 - Technology\n\tOption 7 - Weapons\n\tOption 8 - Rare Material\n\tOption 9 - Dark Matter\n");
            Console.WriteLine("{0}, would you like to Buy or Sell");
            Console.ReadLine();
        }

    }
}
