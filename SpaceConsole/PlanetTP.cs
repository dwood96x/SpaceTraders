﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace SpaceConsole
{
    class PlanetTP
    {
        public static bool exitA = true;
        public static void TradingPost(Inventory inventory, Ship playership, Planet currentPlanet)
        {
            // TODO - Find a way to automatically change the text to show the current location

            //string earth = "\nWelcome to the Trading Post of {0}.\n";
            //for (int i = 0; i < earth.Length; i++)
            //{
            //    Console.Write(earth[i]);
            //    System.Threading.
            //    Thread.Sleep(35);
            //}
            Console.WriteLine("\nWelcome to the Trading Post of {0}.\n", currentPlanet.planetName);
            string avail = "\nHere is the list of availble items.\n";
            for (int i = 0; i < avail.Length; i++)
            {
                Console.Write(avail[i]);
                System.Threading.
                Thread.Sleep(35);
            }
            Console.WriteLine("==================================\n");
            Console.WriteLine("\tWater" +
                              "\n\tFood" +                              
                              "\n\tCommon Mineral" +
                              "\n\tMedical Supplies" +
                              "\n\tTechnology" +
                              "\n\tWeapons" +
                              "\n\tRare Material" +
                              "\n\tDark Matter" +
                              "\n\tFuel");
            Console.WriteLine("==================================");

            do
            {
                Console.WriteLine("\n{0}, would you like to Buy, Sell, Upgrade, or Leave", inventory.userName);
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "buy")
                {
                    BuyItems.BItems(inventory, playership, currentPlanet.biome );
                }
                else if (userInput.ToLower() == "sell")
                {
                    SellItems.SItems(inventory, playership, currentPlanet.biome);
                }
                else if (userInput.ToLower() == "leave")
                {
                    Leave(inventory);                    
                }
                else if (userInput.ToLower() == "upgrade")
                {
                    Upgrades.BuyUpgrade(inventory, playership);
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
        public static void Leave(Inventory inventory)
        {
            Console.WriteLine("\n{0}, are you sure you want to leave the Trading Post?\n" + "Yes or No\n" , inventory.userName);
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
