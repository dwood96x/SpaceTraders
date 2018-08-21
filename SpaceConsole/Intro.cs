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
            Console.WriteLine("You have entered {0}, are you sure?" + "Please type Yes or No.", userName);
            string userAnswer = Console.ReadLine();

            if (userAnswer == "No")
            {
                StartPoint();
            }
            else if (userAnswer == "Yes")
            {
                //go to beginning of story line
            }
            else
            {
                Console.WriteLine("You answer is invaild, please try again");
                StartPoint();
            }    

        }
                    
    }
}
