using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Day
    {
        // member variables maybeeeeee nah
        private int lemonsUsed;
        private int sugarUsed;
        private int cupsUsed;
        private int iceCubesUsed;
        public Weather Weather;
        public Customer Customer;

        private int customerList;

        // constructor

        //member methods    
        public void DayKickOff()
        {
            UserInterface.RecipeStatement();
            Player player = new Player();
            UserInterface.LemonRecipePrompt();
            UserInterface.SugarRecipePrompt();
            UserInterface.IceCubeRecipePrompt();
            UserInterface.LemonadePricePrompt();
            UserInterface.StoreStatement();
        }
    }
}