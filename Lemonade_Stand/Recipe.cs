using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Recipe
    {
        // member variables
        private int lemonsPerPitcher;
        private int sugarInCupsPerPitcher;
        private int iceCubesPerCup;
        private double lemonadePrice;

        public double MyProperty
        {
            get
            {
                return lemonadePrice;
            }
            set
            {
                if ((value > 0))
                {
                    lemonadePrice = 0;
                }
            }
        }

        // constructor
        public Recipe()
        {
            lemonsPerPitcher = 4;
            sugarInCupsPerPitcher = 4;
            iceCubesPerCup = 4;

        }

        // member methods
        public void SetRecipe()
        {
            Console.WriteLine("Enter the amount of lemons you would like per pitcher of lemonade");
            lemonsPerPitcher = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount of sugar, in cups, you would like per pitcher of lemonade");
            sugarInCupsPerPitcher = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many ice cubes you will be putting into each glass of lemonade");
            iceCubesPerCup = Convert.ToInt32(Console.ReadLine());
        }
    }
}