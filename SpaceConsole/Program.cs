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
            MainMenu();
 

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
            bool exitChoice = false;
            do
            {
                Console.Clear();
                Console.WriteLine("You are in your ship orbiting {0}", Inventory.currentPlanet);
                Console.WriteLine("\nYou can go to the tradepost, travel, check your inventory (stats), or exit");
                string input = Console.ReadLine();
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
                    Console.WriteLine("Where would you like to warp to? 1 for Earth, 2 for My Great Planet, 3 Alpha Centauri");
                    string travelInput = Console.ReadLine();
                    // do if else
                    Warp.WarpTo(2, Inventory.currentPlanet);
                }
                else if (input.ToLower() == "stats")
                {
                    Inventory.CheckInventory();
                }
                else if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Leaving already? See ya next time. Bye");
                    Console.ReadLine();
                    exitChoice = true;
                }


            } while (exitChoice == false);
        }
    }
}