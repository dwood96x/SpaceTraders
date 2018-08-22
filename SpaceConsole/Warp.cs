using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Warp
    {
        public static void WarpSpeed(double warpFac)
        {
            // User inputs warp speed into method to get the velocity in speed of light
            double warpVel = Math.Pow(warpFac, (10 / 3)) + Math.Pow((10 - warpFac), (-11 / 3));
            Console.WriteLine("Your current speed to this planet is {0} C ", warpVel);
        }
        public static double CurrentSpeed()
        {
            //Request whats speed the user wants to go and checks if its valid
            Console.WriteLine("What speed do you want to go? Your top speed is {0}", Ship.maxSpeed);
            double reqWarp = Double.Parse(Console.ReadLine());
            if (reqWarp > Ship.maxSpeed)
            {
                Console.WriteLine("You can't go that fast! Are you trying to blow yourself up!? Try again!");
                CurrentSpeed();
            }
            else if (reqWarp < 0)
            {
                Console.WriteLine("You realize giving me a negative number wont let us go back in time right? Try again.");
                CurrentSpeed();
            }
            else if (reqWarp < 1)
            {
                Console.WriteLine("I'd rather not get there next century. Try again.");
                CurrentSpeed();
            }
            else
            {
                Console.WriteLine("Warp factor of {0} accepted. Engaging warp in 3... 2... 1...", reqWarp);
            }
            return reqWarp;
        }
        public static void TravelTime(double distance)
        {
            //double travTime = distance / WarpSpeed() * 365;
        }
    }
}
