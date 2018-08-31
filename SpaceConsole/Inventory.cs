using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    public class Inventory
    {
        public string userName;
        public int pCredits;
        public int Age;
        public double totalDistance;
        public string currentPlanet;
        public int totalCredits;
        public static List<string> CargoSpace = new List<string>();
        public static int[] cargoQuantity = new int[8];
        public Inventory(string username, int pcredits, int age, double totaldistance, string Planet, int totalcredits)
        {
            userName = username;
            pCredits = pcredits;
            Age = age;
            totalDistance = totaldistance;
            currentPlanet = Planet;
            totalCredits = totalcredits;
        }
        public int[] InventoryQuantities()
        {
            for (var i = 0; i < CargoSpace.Count; i++)
            {
                switch (CargoSpace[i])
                {
                    case "Water":
                        cargoQuantity[0] += 1;
                        break;
                    case "Food":
                        cargoQuantity[1] += 1;
                        break;
                    case "Common Material":
                        cargoQuantity[2] += 1;
                        break;
                    case "Medical Supplies":
                        cargoQuantity[3] += 1;
                        break;
                    case "Technology":
                        cargoQuantity[4] += 1;
                        break;
                    case "Weapon":
                        cargoQuantity[5] += 1;
                        break;
                    case "Rare Material":
                        cargoQuantity[6] += 1;
                        break;
                    case "Dark Matter":
                        cargoQuantity[7] += 1;
                        break;
                }
            }
            return cargoQuantity;
        }
            public static void AddCargo(string boughtItem, Ship Ship)
        {
            if (CargoSpace.Count == Ship.CurShipSize)
            {
                Console.WriteLine("Your cargospace is full. Sell something or upgrade your ship to get more.");
            }
            else if (CargoSpace.Count < Ship.CurShipSize)
            {
                Console.WriteLine("Adding {0} to your cargo.", boughtItem);
                CargoSpace.Add(boughtItem);
            }
        }
        public static void RemoveCargo(string removeItem)
        {
            CargoSpace.Remove(removeItem);
            Console.WriteLine("{0} removed from cargo.", removeItem);
        }

        public static void CheckInventory(Ship Ship, Inventory inventory)
        {
            Console.WriteLine("You are {0} years old.", inventory.Age);
            Console.WriteLine("You have {0} credits.", inventory.pCredits);
            Console.WriteLine("You are at {0}", inventory.currentPlanet);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Your ship is a {0} and has a max cargo space of {1}", Ship.ShipName, Ship.CurShipSize );
            Console.WriteLine("--------------------------------------");
            for (var i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"Quantity of Water: {cargoQuantity[i]}");
                        break;
                    case 1:
                        Console.WriteLine($"Quantity of Food: {cargoQuantity[i]}");
                        break;
                    case 2:
                        Console.WriteLine($"Quantity of Common Material: {cargoQuantity[i]}");
                        break;
                    case 3:
                        Console.WriteLine($"Quantity of Medical Supplies: {cargoQuantity[i]}");
                        break;
                    case 4:
                        Console.WriteLine($"Quantity of Technology: {cargoQuantity[i]}");
                        break;
                    case 5:
                        Console.WriteLine($"Quantity of Weapon: {cargoQuantity[i]}");
                        break;
                    case 6:
                        Console.WriteLine($"Quantity of Rare Material: {cargoQuantity[i]}");
                        break;
                    case 7:
                        Console.WriteLine($"Quantity of Dark Matter: {cargoQuantity[i]}");
                        break;
                }
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}