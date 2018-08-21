using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Intro
    {
        public static void StartPoint() 
        {
            Console.WriteLine("Greetings traveler, what shall we call you by? \n");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You have entered {0}, are you sure?  Please type Yes or No.", userName);
            string userAnswer = Console.ReadLine();

            if (userAnswer.ToLower() == "no")
            {
                Console.WriteLine("\nYou have answered No.\n");
                StartPoint();
            }
            else if (userAnswer.ToLower() == "yes")
            {
                Console.WriteLine("\nYou have answered Yes.\n");
                BeginSL(userName);
            }
            else
            {
                Console.WriteLine("You answer is invaild, please try again");
                StartPoint();
            }
        }
        public static void BeginSL(string userName)
        {
            Console.WriteLine("{0}, you have inherited the family ship in the trading business." , userName);
            Console.WriteLine("Your family also left you with something else.....");
            Console.WriteLine("The family debt of $1000000 credits.\n");
        }
    }
}
