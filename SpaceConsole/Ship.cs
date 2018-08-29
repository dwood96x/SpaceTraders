using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    public class Ship
    {
        public string ShipName;
        public double MaxSpeed;
        public double CurShipSize;
        public double ShipCost;
        public double MaxFuel;

        public Ship(string shipName, double maxSpeed, double curShipSize, double shipCost, double maxFuel)
        {
            ShipName = shipName;
            MaxSpeed = maxSpeed;
            CurShipSize = curShipSize;
            ShipCost = shipCost;
            MaxFuel = maxFuel;
        }
        /*
        public string GetShipName()
        {
            return ShipName;
        }
        public double GetMaxSpeed()
        {
            return MaxSpeed;
        }
        public double GetShipSize()
        {
            return CurShipSize;
        }
        public double GetShipCost()
        {
            return ShipCost;
        }
        public double GetShipMaxFuel()
        {
            return MaxFuel;
        }
        public void Krillan()
        {
            ShipName = "Krillan";
            MaxSpeed = 3;
            CurShipSize = 3;
            ShipCost = 2000;
            MaxFuel = 10;
        }
        public void Piccolo()
        {
            ShipName = "Piccolo";
            MaxSpeed = 5;
            CurShipSize = 6;
            ShipCost = 15000;
            MaxFuel = 15;
        }
        public void Vegito()
        {
            ShipName = "Vegito";
            MaxSpeed = 7;
            CurShipSize = 9;
            ShipCost = 50000;
            MaxFuel = 20;
        }
        public void MajinBuu()
        {
            ShipName = "Majin Buu";
            MaxSpeed = 6;
            CurShipSize = 12;
            ShipCost = 100000;
            MaxFuel = 25;
        }
        */
    }
}
