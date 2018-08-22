using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Space Traders 9000. \n");
            Inventory.userName = Intro.StartPoint();

            Time.TimePassed();
            /* Test functions :
            Console.WriteLine(userName);
            Warp.WarpSpeed(Warp.CurrentSpeed());
            Inventory.checkInventory();
            */
            //string userName = Intro.StartPoint();
            //Console.WriteLine(userName);
            PlanetTP.EarthTP();

            //Warp.WarpSpeed(Warp.CurrentSpeed());

        }

    }
}