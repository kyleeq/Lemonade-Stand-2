using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Player
    {
        private int expenses;
        private int income;

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