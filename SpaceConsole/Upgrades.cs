using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Upgrades
    {
        public static void BuyUpgrade(Inventory inventory, Ship playership)
        {
            int maxfuelupprice = 5000;
            int cargoupprice = 7000;
            int speedupprice = 10000;
            Console.Clear();
            bool leave = false;
            Console.WriteLine("Which upgrade would you like to buy {0}?", inventory.userName);
            Console.WriteLine("==============================================");
            Console.WriteLine("\tMax Fuel +2                {0}c", maxfuelupprice);
            Console.WriteLine("\tCargo +2                   {0}c", cargoupprice);
            if (playership.MaxSpeed < 10)
                {
                 Console.WriteLine("\tSpeed +1               {0}c", speedupprice);
                }
            Console.WriteLine("\tLeave");
            do
            {
                Console.WriteLine("\nWhats your choice?");
                string input = Console.ReadLine();
                if (input.ToLower() == "max fuel")
                {
                    if (inventory.pCredits < 5000)
                    {
                        Console.WriteLine("You dont have enough credits! Sorry!");
                    }
                    else
                    {
                        playership.FuelUpgrade();
                        Console.WriteLine("You bought the fuel upgrade!");
                        inventory.pCredits -= maxfuelupprice;
                        Console.WriteLine("\nYou have {0} credits left.", inventory.pCredits);
                        Console.WriteLine("Press ENTER to continue");
                        Console.ReadLine();
                    }
                }
                else if (input.ToLower() == "cargo")
                {
                    if (inventory.pCredits < 7000)
                    {
                        Console.WriteLine("You dont have enough credits! Sorry!");
                    }
                    else
                    {
                        playership.CargoUpgrade();
                        Console.WriteLine("You bought the cargo upgrade!");
                        inventory.pCredits -= cargoupprice;
                        Console.WriteLine("\nYou have {0} credits left.", inventory.pCredits);
                        Console.WriteLine("Press ENTER to continue");
                        Console.ReadLine();
                    }
                }
                else if (input.ToLower() == "speed")
                {
                    if (inventory.pCredits < 10000 || playership.MaxSpeed == 10)
                    {
                        Console.WriteLine("You dont have enough credits or your already at the max speed of 10! Sorry!");
                    }
                    else
                    {
                        playership.SpeedUpgrade();
                        Console.WriteLine("You bought the speed upgrade!");
                        inventory.pCredits -= speedupprice;
                        Console.WriteLine("\nYou have {0} credits left.", inventory.pCredits);
                        Console.WriteLine("Press ENTER to continue");
                        Console.ReadLine();

                    }
                }
                else if (input.ToLower() == "leave")
                {
                    leave = true;
                }
                else
                {
                    Console.WriteLine("Invalid selection! Please try again.");
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                }
            } while (leave == false);
        }
    }
}
