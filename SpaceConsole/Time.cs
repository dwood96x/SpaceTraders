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
            daysPassed += Warp.timeTrav;
            if (daysPassed >= 365)
            {
                Console.WriteLine("One year has passed. You are now {0} years old.");
            }
        }

    }
}
