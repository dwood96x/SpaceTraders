using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Time
    {
        public static uint daysPassed;
        public static void TimePassed()
        {
            //daysPassed += Warp.timeTrav;
            if (daysPassed >= 365)
            {
                Inventory.age += 1;
                Console.WriteLine("One year has passed. You are now {0} years old.", Inventory.age);
                Console.WriteLine("You have {0} years left to pay off your debt.",(60 - Inventory.age));
            }
        }

    }
}
