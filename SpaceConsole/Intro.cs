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
                }
                else if (userNameTemp.Any(Char.IsDigit))
                {
                    Console.WriteLine("Invalid username, try again");
                }
                else
                {
                    invalidUsername = false;
                }

                if (invalidUsername == false)
                {

                    Console.WriteLine("You have entered {0}, are you sure?  Please type Yes or No.\n", userNameTemp);
                    string userAnswer = Console.ReadLine();
                    if (userAnswer.ToLower() == "no")
                    {
                        Console.WriteLine("\nYou have answered No.\n");
                        invalidUsername = true;
                    }
                    else if (userAnswer.ToLower() == "yes")
                    {
                        Console.WriteLine("");
                        userName = userNameTemp;
                        BeginSL(userName);
                        invalidUsername = false;
                    }
                    else
                    {
                        Console.WriteLine("You answer is invaild, please try again");
                        invalidUsername = true;
                    }
                }
                
            } while (invalidUsername == true);
            return userName;
        }
        public static void BeginSL(string userName)
        {
            Console.WriteLine("Press ENTER to continue on your adventure.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{0}, you have inherited the family ship in the trading business." , userName);
            Console.WriteLine("Your family also left you with something else.....");
            Console.WriteLine("The family debt of $1,000,000 credits.\n");
            Console.WriteLine("You have 40 years to amass the money to pay off this debt or face severe consequences.");
            Console.WriteLine("Good luck.\n");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Inventory.age = 20;
            Inventory.pCredits = 2000;
            
            Time.daysPassed = 0;
            Inventory.totalDistance = 0;
            Inventory.currentPlanet = "Earth";
            Inventory.userName = userName;

        }
    }
}
