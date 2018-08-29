﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Program
    {
        public static bool exitChoice = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Space Traders 9000. \n");
            Intro.StartPoint();
            // Next lines set initial game conditions
            Ship playerShip = new Ship("Krillan", 3, 4, 5000, 10);
            Inventory.SetMaxCargo(playerShip);
            MainMenu(playerShip);
 
            /* Test functions :
            Warp.WarpTo(2, Inventory.currentPlanet);
            Inventory.checkInventory();
            PlanetTP.EarthTP();
            */
        }

        public static void MainMenu(Ship shipname)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("You are in your ship orbiting {0}", Inventory.currentPlanet);
                Console.WriteLine("\nYou can go to the Trade Post, Travel, Inventory, or Exit");
                string input = Console.ReadLine();
                if (input.ToLower() == "trade post")
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
                    Console.WriteLine("\nWhere would you like to warp to? \n\tEarth, My Great Planet, or Alpha Centauri?");
                    string travelInput = Console.ReadLine();
                    int travelChoice = 0;
                    if (travelInput.ToLower() == "earth" && Inventory.currentPlanet != "Earth")
                    {
                        travelChoice = 1;
                    }
                    else if (travelInput.ToLower() == "my great planet" && Inventory.currentPlanet != "My Great Planet")
                    {
                        travelChoice = 2;
                    }
                    else if (travelInput.ToLower() == "alpha centauri" && Inventory.currentPlanet != "Alpha Centauri")
                    {
                        travelChoice = 3;
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection, your either already on that planet or you spelled it incorrectly.");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                    if (travelChoice != 0)
                    {
                        Warp.WarpTo(travelChoice, Inventory.currentPlanet, shipname);
                    }
                }
                else if (input.ToLower() == "inventory")
                {
                    Inventory.CheckInventory(shipname);
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