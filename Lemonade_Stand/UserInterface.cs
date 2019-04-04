﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public static class UserInterface
    {
        
        public static void InitialStatement()
        {
            Console.WriteLine("Welcome to Lemonade Stand! This is how you play the game...");
            Console.ReadLine();
        }

        public static void RecipeStatement()
        {
            Console.WriteLine("Would you like to enter in your own recipe or use the generic recipe? Please type in 'my own' or 'generic'. " +
                    "The generic recipe consists of four lemons and four cups of sugar per pitcher and four ice cubes per glass of lemonade");
            Console.ReadLine();
        }
        public static int LemonRecipePrompt()
        {
            Console.WriteLine("Enter the amount of lemons you would like per pitcher of lemonade");
            int lemonsPerPitcher = Convert.ToInt32(Console.ReadLine());
            return lemonsPerPitcher;

        }
        public static int SugarRecipePrompt()
        {
            Console.WriteLine("Enter the amount of sugar, in cups, you would like per pitcher of lemonade");
            int sugarInCupsPerPitcher = Convert.ToInt32(Console.ReadLine());
            return sugarInCupsPerPitcher;
        }
        public static int IceCubeRecipePrompt()
        {
            Console.WriteLine("Enter how many ice cubes you will be putting into each glass of lemonade");
            int iceCubesPerCup = Convert.ToInt32(Console.ReadLine());
            return iceCubesPerCup;
        }
        public static void StoreStatement()
        {
            Console.WriteLine("Let's go to the store and purchase some ingrediants for your lemonade.");
            Console.ReadLine();
        }
        public static int BuyLemons()
        {

        }
        public static int BuySugar()
        {

        }
        public static int BuyIceCubes()
        {

        }
        public static int BuyCups()
        {

        }
    }
}