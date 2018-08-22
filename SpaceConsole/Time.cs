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
                Inventory.age += 1;
                daysPassed -= 365;
                Console.WriteLine("{1} year has passed. You are now {0} years old.", Inventory.age);                
            }
            Console.WriteLine("You have {0} years left to pay off your debt.", (60 - Inventory.age));
            Console.WriteLine(Warp.travTime);

        }

    }
}
