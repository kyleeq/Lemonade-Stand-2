﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Child : Customer
    {
        // member variables



        // constructor
        public Child()
        {          
            
        }

        // member methods
        public override void PricePointDeterminant(double lemonadePrice)
        {
            if (lemonadePrice < 0.25)
            {
                for (double i = 0; i <= 50; i += 2);
            }
            else if (lemonadePrice >= 0.25 && lemonadePrice < 0.50)
            {
                for (double i = 0; i <= 50; i += 4);
            }
            else if (lemonadePrice <= 0.50 && lemonadePrice < 0.75)
            {
                for (double i = 0; i <= 50; i += 7);
            }
            else
            {
                for (double i = 0; i <= 50; i += 10) ;
            }

                    
        }
    }
}