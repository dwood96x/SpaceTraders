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


            /* Test functions :
            Warp.WarpTo(2, Inventory.currentPlanet);
            Time.TimePassed();
            Console.WriteLine(userName);
            Warp.WarpSpeed(Warp.CurrentSpeed());
            Inventory.checkInventory();
            PlanetTP.EarthTP();
            */


        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("You are in your ship now.");
            Console.WriteLine("\nYou can go to the TradePost, Travel, Check your stats, or exit");

        }

    }
}