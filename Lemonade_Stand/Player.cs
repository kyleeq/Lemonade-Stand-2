using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Player
    {
        // member variables
        private double expenses;
        private double income;
        private double startingMoney;

        // constructor
        public Player()
        {
            startingMoney = 20.00;
        }

        // member methods

        public Inventory Inventory
        {
            get => default(Inventory);
            set
            {
            }
        }

        public Recipe Recipe
        {
            get => default(Recipe);
            set
            {
            }
        }
    }
}