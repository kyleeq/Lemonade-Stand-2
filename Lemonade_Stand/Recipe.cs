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
        private int sugerInCupsPerPitcher;
        private int iceCubesPerCup;

        // constructor

        // member methods
        public void SetRecipe(int lemonsPerPitcher, int sugarInCupsPerPitcher, int iceCubesPerCup)
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