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
                // TODO - Needs to account for multiple years passing in 1 travel
                //Inventory.age += (Convert.ToInt32(daysPassed)/365);
                Inventory.age += 1;
                daysPassed -= 365;
                Console.WriteLine("One year has passed. You are now {0} years old.", Inventory.age);
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
                // TODO - Needs story
                Console.Clear();
                Console.WriteLine("The time has come to pay off your debt!");
                Console.WriteLine("You didn't make enough money to pay it all off! The banks sent bounty hunters after you!");
                Console.WriteLine("Your dead!", Console.ForegroundColor = ConsoleColor.DarkRed);
            }
        }

    }
}
