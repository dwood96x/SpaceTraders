using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace SpaceConsole
{
    class PlanetTP
    {
        public static bool exitA = true;
        public static void EarthTP()
        {
            string earth = "\nWelcome to the Trading Post of Earth.\n";
            for (int i = 0; i < earth.Length; i++)
            {
                Console.Write(earth[i]);
                System.Threading.
                Thread.Sleep(60);
            }
            string avail = "\nHere is the list of availble items.\n";
            for (int i = 0; i < avail.Length; i++)
            {
                Console.Write(avail[i]);
                System.Threading.
                Thread.Sleep(60);
            }
            Console.WriteLine("==================================\n");
            Console.WriteLine("\t1 - Water\n\t2 - Food\n\t3 - Fuel" +
                             "\n\t4 - Common Mineral\n\t5 - Medical Supplies\n\t6 - Technology" +
                              "\n\t7 - Weapons\n\t8 - Rare Material\n\t9 - Dark Matter\n");
            Console.WriteLine("==================================");

            do
            {
                Console.WriteLine("\n{0}, would you like to Buy, Sell, or Leave", Inventory.userName);
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "buy")
                {
                    BuyItems.BItems();
                }
                else if (userInput.ToLower() == "sell")
                {
                    SellItems.SItems();
                }
                else if (userInput.ToLower() == "leave")
                {
                    Leave();                    
                }
                else
                {
                    string invaild = "\nYou answer is invaild, please try again\n";
                    for (int i = 0; i < invaild.Length; i++)
                    {
                        Console.Write(invaild[i]);
                        System.Threading.
                        Thread.Sleep(60);
                    }                    
                }

            } while (exitA == true);
        }
        public static void MyGPTP()
        {
            string MyGPTP = "\nWelcome to the Trading Post of My Great Planet.\n";
            for (int i = 0; i < MyGPTP.Length; i++)
            {
                Console.Write(MyGPTP[i]);
                System.Threading.
                Thread.Sleep(60);
            }
            string avail = "\nHere is the list of availble items.\n";
            for (int i = 0; i < avail.Length; i++)
            {
                Console.Write(avail[i]);
                System.Threading.
                Thread.Sleep(60);
            }
            
            Console.WriteLine("===========================================\n");
            Console.WriteLine("\tOption 1 - Water\n\tOption 2 - Food\n\tOption 3 - Fuel" +
                             "\n\tOption 4 - Common Mineral\n\tOption 5 - Medical Supplies\n\tOption 6 - Technology\n" +
                              "\tOption 7 - Weapons\n\tOption 8 - Rare Material\n\tOption 9 - Dark Matter\n");
            do
            {

                Console.WriteLine("{0}, would you like to Buy, Sell, or Leave", Inventory.userName);
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "buy")
                {
                    BuyItems.BItems();
                }
                else if (userInput.ToLower() == "sell")
                {
                    SellItems.SItems();
                }
                else if (userInput.ToLower() == "leave")
                {
                    Leave();
                }
                else
                {
                    Console.WriteLine("You answer is invaild, please try again");
                }

            } while (exitA == true);
        }
        public static void ACTP()
        {
            string ACTP = "\nWelcome to the Trading Post of Alpha Centauri";
            for (int i = 0; i < ACTP.Length; i++)
            {
                Console.Write(ACTP[i]);
                System.Threading.
                Thread.Sleep(60);
            }
            string avail = "\nHere is the list of availble items.\n";
            for (int i = 0; i < avail.Length; i++)
            {
                Console.Write(avail[i]);
                System.Threading.
                Thread.Sleep(60);
            }
            Console.WriteLine("===========================================\n");
            Console.WriteLine("\tOption 1 - Water\n\tOption 2 - Food\n\tOption 3 - Fuel" +
                             "\n\tOption 4 - Common Mineral\n\tOption 5 - Medical Supplies\n\tOption 6 - Technology\n" +
                              "\tOption 7 - Weapons\n\tOption 8 - Rare Material\n\tOption 9 - Dark Matter\n");
            do
            {

                Console.WriteLine("{0}, would you like to Buy, Sell, or Leave", Inventory.userName);
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "buy")
                {
                    BuyItems.BItems();
                }
                else if (userInput.ToLower() == "sell")
                {
                    SellItems.SItems();
                }
                else if (userInput.ToLower() == "leave")
                {
                    Leave();
                }
                else
                {
                    Console.WriteLine("You answer is invaild, please try again");

                }

            } while (exitA == true);
        }       
        
        public static void Leave()
        {
            Console.WriteLine("\n{0}, are you sure you want to leave the Trading Post?\n" + "Yes or No\n" , Inventory.userName);
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "yes")
            {
                exitA = false;               
            }
            else
            {

            }
            
        }
    }
}
