using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Game
    {
        // member variables

        // constructor

        // member methods

        public void InitialStatement()
        {
            Console.WriteLine("Welcome to Lemonade Stand! This is how you play the game...");
        }
        public Day Day
        {
            get => default(Day);
            set
            {
            }
        }

        public Store Store
        {
            get => default(Store);
            set
            {
            }
        }

        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }
    }
}