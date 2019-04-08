using System;
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
        public override void PricePointDeterminant(double lemonadePrice, double currentTemp)
        {
            int customerPercent;

            if (lemonadePrice < 0.25)
            {
                if (currentTemp > 75)
                {
                    willBuy = true;
                }
            }
            else if (lemonadePrice >= 0.25 && lemonadePrice < 0.50)
            {
                if (currentTemp < 75)
                {
                    customerPercent = customerGenerator.Next(2);
                    if (customerPercent == 2)
                    {
                        willBuy = true;
                    }
                }
            }
            else if (lemonadePrice <= 0.50 && lemonadePrice < 0.75)
            {
                if (currentTemp > 80)
                {
                    customerPercent = customerGenerator.Next(4);
                    if (customerPercent == 4)
                    {
                        willBuy = true;
                    }
                }
            }
            else if (lemonadePrice <= 0.75 && lemonadePrice < 1.00)
            {
                if (currentTemp > 85)
                {
                    customerPercent = customerGenerator.Next(6);
                    if (customerPercent == 6)
                    {
                        willBuy = true;
                    }
                }
            }
            else
            {
                if (currentTemp > 90)
                {
                    customerPercent = customerGenerator.Next(7);
                    if (customerPercent == 7)
                    {
                        willBuy = true;
                    }
                }
            }
        }
    }
}