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
            string userName = Intro.StartPoint();
            Console.WriteLine(userName);
            //Warp.WarpSpeed(Warp.CurrentSpeed());
        }

    }
}