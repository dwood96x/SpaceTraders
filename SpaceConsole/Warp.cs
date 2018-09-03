using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Warp
    {
        
        public static double travTime;
        public static double WarpSpeed(double warpFac = 2)
        {
            // User inputs warp speed into method to get the velocity in speed of light, has default warp factor of 2
            double warpVel = Math.Pow(warpFac, (10 / 3)) + Math.Pow((10 - warpFac), (-11 / 3));
            Console.WriteLine("Your current speed to this planet is {0:F2} C ", warpVel);
            return warpVel;
        }
        /* Unneeded code
        public static double CalcDistance(double a, double b)
        {
            double distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return distance;
        }
        */
        public static double CurrentSpeed(Ship shipname)
        {
            //Request whats speed the user wants to go and checks if its valid
            bool acceptedSpeed = false;
            double reqWarp;
            do
            {
                Console.WriteLine("What speed do you want to go? Your top speed is {0}", shipname.MaxSpeed);
                reqWarp = Double.Parse(Console.ReadLine());
                
            
                if (reqWarp > shipname.MaxSpeed)
                {
                    Console.WriteLine("You can't go that fast! Are you trying to blow yourself up!? Try again!");
                }
                else if (reqWarp < 0)
                {
                    Console.WriteLine("A negative warp factor? Are you serious? Try again.");
                }
                else if (reqWarp < 1)
                {
                    Console.WriteLine("I'd rather not get there next century. Try again.");
                }
                else
                {
                    Console.WriteLine("Warp factor of {0} accepted. Engaging warp in 3... 2... 1...", reqWarp);
                    acceptedSpeed = true;
                }
            } while (acceptedSpeed == false);
            return reqWarp;
        }
        public static void TravelTime(double distance,Ship shipname, Inventory inventory)
        {
            // Calculates time to get to destination in days
            travTime = distance / WarpSpeed(CurrentSpeed(shipname)) * 365;
            Console.WriteLine("It will take {0:F2} days to get to the destination", travTime);
            inventory.totalDistance += distance;
        }
        public static void WarpTo(Planet currentplanet, Planet toPlanet, Ship playership, Inventory player)
        {
            TravelTime(Planet.Distance(currentplanet,toPlanet),playership, player);
            double fuelused = Planet.Distance(currentplanet, toPlanet);
            playership.CurrentFuel -= fuelused;
            Console.WriteLine("You use up {0:F2} fuel", fuelused);
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Time.TimePassed(player, playership);
            travTime = 0;
        }
        
    }
}
