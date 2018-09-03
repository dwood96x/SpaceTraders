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
        public double pCredits;
        public double Age;
        public double totalDistance;
        public string currentPlanet;
        public double totalCredits;
        public static List<string> CargoSpace = new List<string>();
        public static double[] cargoQuantity = new double[8];
        public Inventory(string username, double pcredits, double age, double totaldistance, string Planet, double totalcredits)
        {
            userName = username;
            pCredits = pcredits;
            Age = age;
            totalDistance = totaldistance;
            currentPlanet = Planet;
            totalCredits = totalcredits;
        }
        public static double[] InventoryQuantities()
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
                Console.WriteLine("Your cargo space is full. Sell something or upgrade your ship to get more.");
            }
            else if (CargoSpace.Count < Ship.CurShipSize)
            {
                Console.WriteLine("Adding {0} to your cargo.", boughtItem);
                CargoSpace.Add(boughtItem);
            }
        }
        public static void RemoveCargo(string removeItem, Ship ship)
        {
            CargoSpace.Remove(removeItem);
            Console.WriteLine("{0} removed from cargo.", removeItem);
        }

        public static void CheckInventory(Ship Ship, Inventory inventory)
        {
            Console.WriteLine("You are {0} years old.", inventory.Age);
            Console.WriteLine("You have {0} credits.", inventory.pCredits);
            Console.WriteLine("You have {0:F2} fuel in your tank and have a max capacity of {1}", Ship.CurrentFuel, Ship.MaxFuel);
            Console.WriteLine("You are at {0}", inventory.currentPlanet);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Your ship is a {0} with a max speed of {2} and has a max cargo space of {1}", Ship.ShipName, Ship.CurShipSize, Ship.MaxSpeed );
            Console.WriteLine("--------------------------------------");
            InventoryQuantities();
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
            Console.WriteLine("\n\tPress enter to continue");
            Console.ReadLine();
            Array.Clear(cargoQuantity, 0, 8);
        }
    }
}