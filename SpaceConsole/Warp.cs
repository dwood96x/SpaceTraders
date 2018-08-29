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
        public static double CalcDistance(double a, double b)
        {
            double distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return distance;
        }
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
        public static void TravelTime(double distance,Ship shipname)
        {
            // Calculates time to get to destination in days
            travTime = distance / WarpSpeed(CurrentSpeed(shipname)) * 365;
            Console.WriteLine("It will take {0:F2} days to get to the destination", travTime);
            Inventory.totalDistance += distance;
        }
        public static void WarpTo(int toPlanet, string fromPlanet, Ship shipname)
        {

            // earth to mgp 6.794 , earth to AC 4.367, MGP to AC 10.44
            // Earth is (0,0) , My Great Planet is (-4.6, 5) Alpha Centauri is (0, 4.367)
            if (toPlanet == 1 && fromPlanet == "My Great Planet")
            {
                TravelTime(6.794, shipname);
                Inventory.currentPlanet = "Earth";
            }
            else if (toPlanet == 1 && fromPlanet == "Alpha Centauri")
            {
                TravelTime(4.367, shipname);
                Inventory.currentPlanet = "Earth";
            }
            else if (toPlanet == 2 && fromPlanet == "Earth")
            {
                TravelTime(6.794, shipname);
                Inventory.currentPlanet = "My Great Planet";
            }
            else if (toPlanet == 2 && fromPlanet == "Alpha Centauri")
            {
                TravelTime(10.44, shipname);
                Inventory.currentPlanet = "My Great Planet";
            }
            else if (toPlanet == 3 && fromPlanet == "Earth")
            {
                TravelTime(4.367, shipname);
                Inventory.currentPlanet = "Alpha Centauri";
            }
            else if (toPlanet == 3 && fromPlanet == "My Great Planet")
            {
                TravelTime(10.44, shipname);
                Inventory.currentPlanet = "Alpha Centauri";
            }
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Time.TimePassed();
            travTime = 0;
        }
    }
}
