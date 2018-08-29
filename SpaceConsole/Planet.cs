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
        public static double Distance(Planet currentPlant, Planet destination)
        {
            a = currentPlant.xCoord - destination.xCoord;
            b = currentPlant.yCoord - destination.xCoord;
            return Math.Sqrt(Math.Pow(a, 2.0) + Math.Pow(b, 2.0));
        }



    //This is the formula and coords for the 8 planets.
    //Need to pass to program and intergrate to current code.
    }
}
