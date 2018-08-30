using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Time
    {
        public static double daysPassed;
        public static void TimePassed(Inventory inventory)
        {
            daysPassed += Warp.travTime;
            if (daysPassed >= 365)
            {
                if (daysPassed >= 730)
                {
                    int yearsPassed = (Convert.ToInt32(daysPassed) / 365);
                    inventory.Age += yearsPassed;
                    daysPassed -= yearsPassed * 365;
                    Console.WriteLine("{1} years passed. You are now {0} years old.", inventory.Age, yearsPassed);
                }
                else if (daysPassed < 730)
                {
                    inventory.Age += 1;
                    daysPassed -= 365;
                    Console.WriteLine("One year has passed. You are now {0} years old.", inventory.Age);
                }


                Console.WriteLine("\nYou have {0} years left to pay off your debt.", (60 - inventory.Age));
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                EndCheck(inventory);
            }
        }
        public static void EndCheck(Inventory inventory)
        {
            if (inventory.pCredits <= 0)
            {
                Console.Clear();
                Console.WriteLine("You get ambushed by pirates!");
                Console.WriteLine("The captain of the pirate crew demands all the credits you have!");
                Console.WriteLine("Realizing your account is empty you soon after get boarded by the pirates!");
                Console.WriteLine("They easily overpower you and take over the ship, forcing you to be their space slave!");
                Console.WriteLine("Months go by until you hear the sound of laser fire rocking the ship!");
                Console.WriteLine("You look out a window and see police cruisers!");
                Console.WriteLine("Press enter to continue");
                Console.WriteLine("PEW a laser hit the window you where at!");
            }
            else if (inventory.Age >= 60)
            {
                // TODO - Needs more story
                Console.Clear();
                Console.WriteLine("The time has come to pay off your debt!");
                Console.WriteLine("You send your credits to the debt collection agency.");
                Console.WriteLine("Press ENTER to see your fate");
                Console.ReadLine();
                if (inventory.pCredits >= 1000000)
                {
                    Console.WriteLine("A shadowy figure approaches.");
                    Console.WriteLine("Wow thats a lot of credits you made there buddy.");
                    Console.WriteLine("You really were trying to make it out alive huh?");
                    Console.WriteLine("Its a real shame, you dont have enough money.\n");
                    Console.WriteLine("What? You didn't think we charged INTEREST? Of course we did!");
                    Console.WriteLine("At 5% per year too! Whats wrong you don't have 7,039,988 credits?");
                    Console.WriteLine("Guess we'll just reprocess your ship and well......... kill you.");
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                }
                else if (inventory.pCredits < 1000000)
                {
                    Console.WriteLine("", Console.ForegroundColor = ConsoleColor.Green);
                    string shadow = ("\nA shadow figure approaches.\n\n");
                        
                    for (int i = 0; i < shadow.Length; i++)
                    {
                        Console.Write(shadow[i]);
                        System.Threading.
                        Thread.Sleep(60);
                    }
                    string message = ("\nYou tried to pay us with THAT measily amount of credits?!?\n\n");
                    for (int i = 0; i < message.Length; i++)
                    {
                        Console.Write(message[i]);
                        System.Threading.
                        Thread.Sleep(60);
                    }
                    string debt = ("Don't worry, you still get to pay off your debt......");
                    for (int i = 0; i < debt.Length; i++)
                    {
                        Console.Write(debt[i]);
                        System.Threading.
                        Thread.Sleep(60);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("", Console.ForegroundColor = ConsoleColor.Red);
                    string soul = ("WITH YOUR SOUL!!!\n\n");
                    for (int i = 0; i < soul.Length; i++)
                    {
                        Console.Write(soul[i]);
                        System.Threading.
                        Thread.Sleep(60);
                    }
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                }
                Console.WriteLine("Your dead!", Console.ForegroundColor = ConsoleColor.Red);
                End.GameOver(inventory);
            }

        }

    }
}
                        
