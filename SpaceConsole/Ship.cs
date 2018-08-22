using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Ship
    {
        public static string shipName;
        public static double maxSpeed;
        public static double curShipSize;
        public static double shipCost;

        public static void Krillan()
        {
             shipName = "Krillan";
             maxSpeed = 2;
             curShipSize = 1;
             shipCost = 2000;
        }
        public static void Piccolo()
        {
             shipName = "Piccolo";
             maxSpeed = 4;
             curShipSize = 2;
             shipCost = 15000;
        }
        public static void Vegito()
        {
             shipName = "Vegito";
             maxSpeed = 6;
             curShipSize = 3;
             shipCost = 50000;
        }
        public static void MajinBuu()
        {
             shipName = "Majin Buu";
             maxSpeed = 5;
             curShipSize = 4;
             shipCost = 100000;
        }
    }
}
