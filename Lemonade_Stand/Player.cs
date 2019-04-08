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

        // constructor
        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
        }

        // member methods


    }
}