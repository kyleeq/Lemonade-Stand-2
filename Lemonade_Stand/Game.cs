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

        public int income
        {
            get => default(int);
            set
            {
            }
        }

        public int expenses
        {
            get => default(int);
            set
            {
            }
        }

        public int liquidatedInventoryValue
        {
            get => default(int);
            set
            {
            }
        }
    }
}