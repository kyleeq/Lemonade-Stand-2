﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class MiddleAged : Customer
    {
        // member variables

        // constructor
        public MiddleAged()
        {

        }

        // member methods
        public override void PricePointDeterminant(double lemonadePrice)
        {
            if (lemonadePrice < 0.25)
            {
                for (double i = 0; i <= 25; i++);
            }
            else if (lemonadePrice >= 0.25 && lemonadePrice < 0.50)
            {
                for (double i = 0; i <= 25; i += 2);
            }
            else if (lemonadePrice <= 0.50 && lemonadePrice < 0.75)
            {
                for (double i = 0; i <= 25; i += 4);
            }
            else if (lemonadePrice <= 0.75 && lemonadePrice < 1.00)
            {
                for (double i = 0; i <= 25; i += 6);
            }
            else
            {
                for (double i = 0; i <= 25; i += 7);
            }
        }
    }
}