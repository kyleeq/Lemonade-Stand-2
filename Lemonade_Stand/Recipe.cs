﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Recipe
    {
        private int lemonsPerPitcher;
        private int sugarInCupsPerPitcher;
        private int iceCubesPerCup;
        private double lemonadePrice;

        public double LemonadePrice
        {
            get
            {
                return lemonadePrice;
            }
            set
            {
                if ((value < 0))
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