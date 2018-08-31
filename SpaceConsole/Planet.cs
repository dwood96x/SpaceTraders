using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Planet
    {
        public double xCoord;
        public double yCoord;
        public string planetName;
        public static double a;
        public static double b;

        public Planet(double x, double y, string pn)
        {
            xCoord = x;
            yCoord = y;
            planetName = pn;
        }
        public static double Distance(Planet currentPlanet, Planet destination)
        {
            a = currentPlanet.xCoord - destination.xCoord;
            b = currentPlanet.yCoord - destination.yCoord;
            return Math.Sqrt(Math.Pow(a, 2.0) + Math.Pow(b, 2.0));
        }
        public object GetPlanetName()
        {
            return planetName;
        }

        //This is the formula and coords for the 8 planets.
    }
}
