using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class End
    {
        public static void GameOver()
        {
            Console.WriteLine("Game over!");
            Console.WriteLine("Press enter to see your stats.");
            Console.ReadLine();
            Console.WriteLine("Credits currently owned : {0}", Inventory.pCredits);
            Console.WriteLine("Your total credits earned: {0}", Inventory.totalCredits);
            Console.WriteLine("Total distance traveled: {0}", Inventory.totalDistance);
            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
            Program.exitChoice = true;
        }
    }
}
