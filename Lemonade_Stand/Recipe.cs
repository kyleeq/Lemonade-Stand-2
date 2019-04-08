using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Recipe
    {
        public double lemonsPerPitcher;
        public double sugarInCupsPerPitcher;
        public double iceCubesPerCup;
        public double lemonadePrice;        

        // constructor
        public Recipe()

        {
            lemonsPerPitcher = 0.25;
            sugarInCupsPerPitcher = 0.25;
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