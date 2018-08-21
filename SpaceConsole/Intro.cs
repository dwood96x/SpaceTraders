using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceConsole
{
    class Intro
    {
        public static string StartPoint() 
        {
            string userName = null;
            bool invalidUsername = true;
            do
            {

                Console.WriteLine("Greetings traveler, what shall we call you by? \n");
                string userNameTemp = Console.ReadLine();
                Console.WriteLine();
                if (String.IsNullOrEmpty(userNameTemp))
                {
                    Console.WriteLine("Invalid username, try again");
                    invalidUsername = true;
                }
                else if (userNameTemp.Any(Char.IsDigit))
                {
                    Console.WriteLine("Invalid username, try again");
                    invalidUsername = true;
                }
                if (invalidUsername == false)
                {

                    Console.WriteLine("You have entered {0}, are you sure?  Please type Yes or No.", userNameTemp);
                    string userAnswer = Console.ReadLine();
                    if (userAnswer.ToLower() == "no")
                    {
                        Console.WriteLine("\nYou have answered No.\n");
                    }
                    else if (userAnswer.ToLower() == "yes")
                    {
                        Console.WriteLine("\nYou have answered Yes.\n");
                        userName = userNameTemp;
                        BeginSL(userName);
                    }
                    else
                    {
                        Console.WriteLine("You answer is invaild, please try again");
                    }
                }
                
            } while (invalidUsername == true);
            return userName;
        }
        public static void BeginSL(string userName)
        {
            Console.WriteLine("{0}, you have inherited the family ship in the trading business." , userName);
            Console.WriteLine("Your family also left you with something else.....");
            Console.WriteLine("The family debt of $1000000 credits.\n");
        }
    }
}
