using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Program
    {
        public static bool exit = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Space Traders 9000. \n");
            Inventory.userName = Intro.StartPoint();
 

            /* Test functions :
            Warp.WarpTo(2, Inventory.currentPlanet);
            Time.TimePassed();
            Console.WriteLine(userName);
            Warp.WarpSpeed(Warp.CurrentSpeed());
            Inventory.checkInventory();
            PlanetTP.EarthTP();
            */


        }

        public static void MainMenu()
        {
            bool exit = false;
            Console.Clear();
            Console.WriteLine("You are in your ship now.");
            Console.WriteLine("\nYou can go to the TradePost, Travel, Check your stats, or exit");
            string input = Console.ReadLine();
            do
            {
                if (input.ToLower() == "tradepost")
                {
                    if (Inventory.currentPlanet == "Earth")
                    {
                        PlanetTP.EarthTP();
                    }
                    else if (Inventory.currentPlanet == "My Great Planet")
                    {
                        PlanetTP.MyGPTP();
                    }
                    else if (Inventory.currentPlanet == "Alpha Centauri")
                    {
                        PlanetTP.ACTP();
                    }

                }
                else if (input.ToLower() == "travel")
                {
                    //Travel where method here
                }


            } while (exit == false);
        }
    }
}