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
        public static void TimePassed()
        {
            daysPassed += Warp.travTime;
            if (daysPassed >= 365)
            {
                if (daysPassed >= 730)
                {
                    int yearsPassed = (Convert.ToInt32(daysPassed) / 365);
                    Inventory.age += yearsPassed;
                    daysPassed -= yearsPassed * 365;
                    Console.WriteLine("{1} years passed. You are now {0} years old.", Inventory.age, yearsPassed);
                }
                else if (daysPassed < 730)
                {
                    Inventory.age += 1;
                    daysPassed -= 365;
                    Console.WriteLine("One year has passed. You are now {0} years old.", Inventory.age);
                }


                Console.WriteLine("\nYou have {0} years left to pay off your debt.", (60 - Inventory.age));
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                EndCheck();
            }
        }
        public static void EndCheck()
        {
            if (Inventory.age >= 60)
            {
                // TODO - Needs more story
                Console.Clear();
                Console.WriteLine("The time has come to pay off your debt!");
                Console.WriteLine("You send your credits to the debt collection agency.");
                Console.WriteLine("Press ENTER to see your fate");
                Console.ReadLine();
                if (Inventory.pCredits >= 1000000)
                {
                    Console.WriteLine("A shadowy figure approaches.");
                    Console.WriteLine("Wow thats a lot of credits you made there buddy.");
                    Console.WriteLine("You really were trying to make it out alive huh?");
                    Console.WriteLine("Its a real shame you dont have really have enough money though.");
                    Console.WriteLine("What? You didn't think we charged INTEREST? Of course we did!");
                    Console.WriteLine("At 5% per year too! Whats wrong dont have 7,039,988 credits");
                    Console.WriteLine("Guess well just reposses your ship and kill you then.");
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                }
                else if (Inventory.pCredits < 1000000)
                {
                    Console.WriteLine("A shadow figure approaches.");
                    Console.WriteLine("You tried to pay us with THAT measily amount of credits?!? \n Don't worry we'll make sure you pay... \n" +
                        "Press ENTER to continue");
                    Console.ReadLine();
                }

                Console.WriteLine("Your dead!", Console.ForegroundColor = ConsoleColor.Red);
                End.GameOver();
            }
        }

    }
}
