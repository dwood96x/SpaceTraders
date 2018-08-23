using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace SpaceConsole
{
    class PlanetTP
    {
        string[] TpList = new string[] {" ", "Water","Food","Fuel","Common Mineral","Medical Supplies","Technology","Weapons","Rare Material","Dark Matter"};
        public static bool exitA = true;

        public static void EarthTP()

        {
            Console.WriteLine("Welcome to the Trading Post of Earth.\n");
            Console.WriteLine("Here is the list of items availble.\n");
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
                    BuyItems();
                }
                else if (userInput.ToLower() == "sell")
                {
                    SellItems();
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
        public static void MyGPTP()
        {
            Console.WriteLine("Welcome to the Trading Post of My Great plant.\n");
            Console.WriteLine("Here is the list of items availble.\n");
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
                    BuyItems();
                }
                else if (userInput.ToLower() == "sell")
                {
                    SellItems();
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
            Console.WriteLine("Welcome to the Trading Post of Alpha Centauri.\n");
            Console.WriteLine("Here is the list of items availble.\n");
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
                    BuyItems();
                }
                else if (userInput.ToLower() == "sell")
                {
                    SellItems();
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
        public static void BuyItems()
            {
                Console.WriteLine("Which item would you like to buy {0}\n", Inventory.userName);
                Console.WriteLine("===========================================\n");
                Console.WriteLine("\t1 Water\n\t2 Food\n\t3 Fuel" +
                                 "\n\t4 Common Mineral\n\t5 Medical Supplies\n\t6 Technology\n" +
                                  "\t7 Weapons\n\t8 Rare Material\n\t9 Dark Matter\n");
            //need to add a selection here
            }
        public static void SellItems()
        {
            Console.WriteLine("Which item would you like to sell {0}\n", Inventory.userName);
            Console.WriteLine("===========================================\n");
            Console.WriteLine("\t1 Water\n\t2 Food\n\t3 Fuel" +
                                 "\n\t4 Common Mineral\n\t5 Medical Supplies\n\t6 Technology\n" +
                                  "\t7 Weapons\n\t8 Rare Material\n\t9 Dark Matter\n");
            //need to add a selection here
        }
        public static void Leave()
        {
            Console.WriteLine("{0}, are you sure you want to leave the Trading Post?\n" + "Yes or No\n" , Inventory.userName);
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "yes")
            {
                Program.MainMenu();
            }
            else
            {

            }

        }
    }
}
