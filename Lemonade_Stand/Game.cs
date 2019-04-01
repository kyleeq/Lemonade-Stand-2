using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public abstract class Game
    {
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