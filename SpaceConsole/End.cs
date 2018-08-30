using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class End
    {
        public static void GameOver(Inventory inventory)
        {
            Console.WriteLine("Game over!");
            Console.WriteLine("Press enter to see your stats.");
            Console.ReadLine();
            Console.WriteLine("Credits currently owned : {0}", inventory.pCredits);
            Console.WriteLine("Your total credits earned: {0}", inventory.totalCredits);
            Console.WriteLine("Credits needed to pay off debt: {0}", (7039988 - inventory.pCredits));
            Console.WriteLine("Total distance traveled: {0}", inventory.totalDistance);
            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
            Program.exitChoice = true;
        }
    }
}
