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
        public string biome;
        public static double a;
        public static double b;

        public Planet(double x, double y, string pn, string bio)
        {
            xCoord = x;
            yCoord = y;
            planetName = pn;
            biome = bio;
        }
        public static double Distance(Planet currentPlanet, Planet destination)
        {
            a = currentPlanet.xCoord - destination.xCoord;
            b = currentPlanet.yCoord - destination.yCoord;
            return Math.Sqrt(Math.Pow(a, 2.0) + Math.Pow(b, 2.0));
        }
        //This is the formula and coords for the 8 planets.
    }
}
