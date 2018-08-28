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
        public static double maxFuel;

        public static void Krillan()
        {
            shipName = "Krillan";
            maxSpeed = 3;
            curShipSize = 3;
            shipCost = 2000;
            maxFuel = 10;
        }
        public static void Piccolo()
        {
            shipName = "Piccolo";
            maxSpeed = 5;
            curShipSize = 6;
            shipCost = 15000;
            maxFuel = 15;
        }
        public static void Vegito()
        {
            shipName = "Vegito";
            maxSpeed = 7;
            curShipSize = 9;
            shipCost = 50000;
            maxFuel = 20;
        }
        public static void MajinBuu()
        {
            shipName = "Majin Buu";
            maxSpeed = 6;
            curShipSize = 12;
            shipCost = 100000;
            maxFuel = 25;
        }

    }
}
