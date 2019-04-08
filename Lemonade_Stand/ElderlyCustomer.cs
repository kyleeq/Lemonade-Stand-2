using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Elderly : Customer
    {
        // member variables

        // constructor
        public Elderly()
        {

        }

        // member methods
        public override void PricePointDeterminant(double lemonadePrice, double currentTemp)
        {
            int customerPercent;

            if (lemonadePrice < 0.25)
            {
                customerPercent = customerGenerator.Next(2);
                willBuy = true;
            }
            else if (lemonadePrice >= 0.25 && lemonadePrice < 0.50)
            {
                customerPercent = customerGenerator.Next(3);
                if (customerPercent == 3)
                {
                    willBuy = true;
                }
            }
            else if (lemonadePrice <= 0.50 && lemonadePrice < 0.75)
            {
                customerPercent = customerGenerator.Next(5);
                if (customerPercent == 5)
                {
                    willBuy = true;
                }
            }
            else if (lemonadePrice <= 0.75 && lemonadePrice < 1.00)
            {
                customerPercent = customerGenerator.Next(7);
                if (customerPercent == 7)
                {
                    willBuy = true;
                }
            }
            else
            {
                customerPercent = customerGenerator.Next(8);
                if (customerPercent == 8)
                {
                    willBuy = true;
                }
            }
        }
    }
}