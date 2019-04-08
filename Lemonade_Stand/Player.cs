using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Player
    {
        // member variables                
        public Inventory inventory;
        public Recipe recipe;
        public double bank;
        public double sellCup;

        // constructor
        public Player()
        {
            bank = 20.00;
            inventory = new Inventory();
            recipe = new Recipe();
        }

        // member methods
        public bool SoldCupsToItems()
        {
            if (inventory.lemonStock > recipe.lemonsPerPitcher && inventory.sugarStock > recipe.sugarInCupsPerPitcher && inventory.iceStock > recipe.iceCubesPerCup && inventory.cupStock > 0)
            {
                bank += recipe.lemonadePrice;
                inventory.lemonStock -= recipe.lemonsPerPitcher;
                inventory.sugarStock -= recipe.sugarInCupsPerPitcher;
                inventory.iceStock -= recipe.iceCubesPerCup;
                inventory.cupStock --;
                return true;
            }
            else
            {
                return false;
            }

        }
        


    }
}