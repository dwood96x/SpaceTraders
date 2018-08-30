using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Program
    {
        public string ItemName;
        public int ItemPrice;
        public static bool exitChoice = false;
        static void Main(string[] args)
        {
            Planet earth = new Planet(0, 0, "Earth");
            Planet ac = new Planet(0, -4.367, "Alpha Centurion");
            Planet m63 = new Planet(-4.6, 5, "M63");
            Planet p100 = new Planet(-30, -30, "P100");
            Planet grenonus = new Planet(-36, -23, "Grenonus");
            Planet derioa = new Planet(-13, 12, "Derioa");
            Planet esides = new Planet(6, 35, "Esides");
            Planet geitov = new Planet(-28, 38, "Geirtov");


            // Puts planets into a list
            List<Planet> PlanetList = new List<Planet>();
            PlanetList.AddMany(earth, ac, m63, p100, grenonus, derioa, esides, geitov);
            /*Method to list all travelable planets, broken
            foreach (var planet in PlanetList)
            {
                if (Planet.Distance(inventory.currentPlanet,ac) < 10.0)
                {
                    Console.WriteLine(planet.planetName);
                }
            }
            */
            Console.WriteLine("Welcome to Space Traders 9000. \n");

            // Next lines set initial game conditions
            Ship playerShip = new Ship("Krillan", 3, 4, 5000, 10);
            Inventory pInventory = new Inventory("", 2000, 20, 0, "Earth", 2000);
            Inventory.SetMaxCargo(playerShip);

            Intro.StartPoint(pInventory);
            MainMenu(playerShip, pInventory);

            /* Test functions :
            Warp.WarpTo(2, inventory.currentPlanet);
            Inventory.checkInventory();
            PlanetTP.EarthTP();
            */
        }


        public static void MainMenu(Ship shipname, Inventory inventory)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("You are in your ship orbiting {0}", inventory.currentPlanet);
                Console.WriteLine("\nYou can go to the Trade Post, Travel, Inventory, or Exit");
                string input = Console.ReadLine();
                if (input.ToLower() == "trade post")
                {
                    if (inventory.currentPlanet == "Earth")
                    {
                        PlanetTP.EarthTP(inventory);
                    }
                    else if (inventory.currentPlanet == "My Great Planet")
                    {
                        PlanetTP.MyGPTP(inventory);
                    }
                    else if (inventory.currentPlanet == "Alpha Centauri")
                    {
                        PlanetTP.ACTP(inventory);
                    }

                }
                /*
                else if (input.ToLower() == "travel")
                {
                    Console.WriteLine("Where would you like to warp to?");
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine({Planet})
                    }
                }
                */
                /*
                else if (input.ToLower() == "travel")
                {
                    Console.WriteLine("\nWhere would you like to warp to? \n\tEarth, My Great Planet, or Alpha Centauri?");
                    string travelInput = Console.ReadLine();
                    int travelChoice = 0;
                    if (travelInput.ToLower() == "earth" && inventory.currentPlanet != "Earth")
                    {
                        travelChoice = 1;
                    }
                    else if (travelInput.ToLower() == "my great planet" && inventory.currentPlanet != "My Great Planet")
                    {
                        travelChoice = 2;
                    }
                    else if (travelInput.ToLower() == "alpha centauri" && inventory.currentPlanet != "Alpha Centauri")
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
                        Warp.WarpTo(travelChoice, inventory.currentPlanet, shipname);
                    }
                    
                }
                */
                else if (input.ToLower() == "inventory")
                {
                    Inventory.CheckInventory(shipname, inventory);
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
    //Following method used to add objects to list from ArkaneX at https://answers.unity.com/questions/524128/c-adding-multiple-elements-to-a-list-on-one-line.html
    // Thanks man
    public static class ListExtenstions
    {
        public static void AddMany<T>(this List<T> list, params T[] elements)
        {
            list.AddRange(elements);
        }
    }

}