using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Recipe
    {
        public int lemonsPerPitcher;
        public int sugarInCupsPerPitcher;
        public int iceCubesPerCup;
        public double lemonadePrice;        

        // constructor
        public Recipe()

        {
            lemonsPerPitcher = 4;
            sugarInCupsPerPitcher = 4;
            iceCubesPerCup = 4;
        }
        // member variabless
        public void SetRecipe()
        {
            lemonsPerPitcher = UserInterface.LemonRecipePrompt();
            sugarInCupsPerPitcher = UserInterface.SugarRecipePrompt();
            iceCubesPerCup = UserInterface.IceCubeRecipePrompt();
            lemonadePrice = UserInterface.LemonadePricePrompt();
        }
    }
}