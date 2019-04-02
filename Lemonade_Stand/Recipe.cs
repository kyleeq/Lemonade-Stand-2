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
        private int icePerCup;

        // constructor

        // member methods
        public void GetRecipe()
        {
            Console.WriteLine("Would you like to enter in your own recipe or use the generic recipe? Please type in 'my own' or 'generic'. " +
                "The generic recipe consists of four lemons and four cups of sugar per pitcher and four ice cubes per glass of lemonade");
            Console.WriteLine("Enter the amount of lemons you would like per pitcher of lemonade");
            int lemonsPerPitcher = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount of sugar, in cups, you would like per pitcher of lemonade");
            int sugarInCUpsPerPitcher = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many ice cubes you will be putting into each glass of lemonade");
            int icePerCup = Convert.ToInt32(Console.ReadLine());
        }
    }
}