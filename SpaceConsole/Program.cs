using System;
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
            Planet earth = new Planet(0, 0, "Earth", "Earthish");
            Planet ac = new Planet(0, -4.367, "Alpha Centurion", "Marsish");
            Planet m63 = new Planet(-4.6, 5, "M63", "Earthish");
            Planet p100 = new Planet(-10, -8, "P100", "Marsish");
            Planet grenonus = new Planet(-21, -3, "Grenonus", "Earthish");
            Planet derioa = new Planet(-13, 12, "Derioa", "Marsish");
            Planet esides = new Planet(6, 32, "Esides", "Marsish");
            Planet geirtov = new Planet(-28, 38, "Geirtov", "Mining");
            Planet x99 = new Planet(7, 7, "X99", "Marsish");
            List<Planet> PlanetList = new List<Planet>();
            PlanetList.AddMany(earth, ac, m63, p100, grenonus, derioa, esides, geirtov, x99);
      
            Console.WriteLine("Welcome to Space Traders 9000. \n");
            // Next lines set initial game conditions
            Ship playerShip = new Ship("Krillan", 3, 4, 5000, 10, 10);
            Inventory pInventory = new Inventory("", 2000, 20, 0, "Earth", 2000);
            Intro.StartPoint(pInventory);
            MainMenu(playerShip, pInventory, PlanetList);
        }

        public static void MainMenu(Ship Ship, Inventory inventory, List<Planet> planetlist)
        {
            Planet currentplanet = new Planet(0, 0, "Earth", "Earthish");
            do
            {
                Console.Clear();
                Console.WriteLine("You are in your ship orbiting {0}", currentplanet.planetName);
                Console.WriteLine("\nYou can go to the Trade Post, Travel, Inventory, or Exit");
                string input = Console.ReadLine();
                if (input.ToLower() == "trade post")
                {
                    PlanetTP.TradingPost(inventory, Ship, currentplanet);
                }
                else if (input.ToLower() == "travel")
                {
                    Console.WriteLine("Where would you like to warp to? Enter the planet name or leave to exit");
                    foreach (var planetf in planetlist)
                    {
                        if (Planet.Distance(currentplanet, planetf) < Ship.CurrentFuel && Planet.Distance(currentplanet, planetf) != 0)
                        {
                            Console.WriteLine("{0} Economy: {1} :{2:F2} Light years away" ,planetf.planetName, planetf.biome, Planet.Distance(currentplanet,planetf));
                        }
                    }
                    var planetinput = Console.ReadLine();
                    bool properinput = false;
                    do
                    {
                        foreach (var planetf in planetlist)
                        {
                            if (planetinput.ToLower() == planetf.planetName.ToLower() && Ship.CurrentFuel >= Planet.Distance(currentplanet, planetf))
                            {
                                Warp.WarpTo(currentplanet, planetf, Ship, inventory);
                                currentplanet = planetf;
                                properinput = true;
                            }
                        }
                        if (planetinput.ToLower() == "leave")
                        {
                            properinput = true;
                        }
                        else if (properinput == false)
                        {
                            Console.WriteLine("Not enough fuel or invalid input, please try again.");
                            Console.WriteLine("Press ENTER to continue");
                            Console.ReadLine();
                        }
                    } while (properinput == false);
                }
                else if (input.ToLower() == "inventory")
                {
                    Inventory.CheckInventory(Ship, inventory);
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