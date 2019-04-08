using System;
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
        public static double LemonadePricePrompt()
        {
            Console.WriteLine("How much would you like to charge per glass of lemonade?");
            double lemonadePrice = Convert.ToDouble(Console.ReadLine());
            return lemonadePrice;
        }
        public static void StoreStatement()
        {
            Console.WriteLine("Let's go to the store and purchase some ingrediants for your lemonade.");
            Console.ReadLine();
        }
        public static int BuyLemons()
        {
            Console.WriteLine("Enter how many lemons would you like to buy");
            int lemonsBought = Convert.ToInt32(Console.ReadLine());
            return lemonsBought;
        }
        public static int BuySugar()
        {
            Console.WriteLine("Enter how many cups of sugar you would like to buy");
            int sugarBought = Convert.ToInt32(Console.ReadLine());
            return sugarBought;
        }
        public static int BuyIceCubes()
        {
            Console.WriteLine("Enter how many ice cubs you would like to buy");
            int iceCubesBought = Convert.ToInt32(Console.ReadLine());
            return iceCubesBought;
        }
        public static int BuyCups()
        {
            Console.WriteLine("Enter how many paper cups you would like to buy");
            int cupsBought = Convert.ToInt32(Console.ReadLine());
            return cupsBought;
        }
        public static void ForecastedWeatherStatement(Weather weather)
        {
            Console.WriteLine($"The forecasted weather is {weather.ForecastedTemp} and {weather.WeatherQuality}.");
        }
        public static void CurrentWeatherStatement(Weather weather)
        {            
            Console.WriteLine($"It is currently {weather.CurrentTemp} degrees outside and {weather.WeatherQuality}.");
        }
        public static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("Here is your daily inventory report");
            Console.WriteLine($"Lemons: {inventory.lemonStock}");
            Console.WriteLine($"Cups of Sugar: {inventory.sugarStock}");
            Console.WriteLine($"Ice cubes: {inventory.iceStock}");
            Console.WriteLine($"Paper cups: {inventory.cupStock}");
        }
    }
}