using System;
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
        public override void PricePointDeterminant(double lemonadePrice, double currentTemp)
        {
            int customerPercent;
            
            if (lemonadePrice < 0.25)
            {               
                if (currentTemp < 75)
                {
                    willBuy = false;
                }
                willBuy = true;
            }

            else if (lemonadePrice >= 0.25 && lemonadePrice < 0.50)
            {
                if (currentTemp < 80)
                {
                    willBuy = false; 
                    customerPercent = customerGenerator.Next(2);
                    if (customerPercent == 2)
                    {
                        willBuy = true;
                    }
                }
            }
            else if (lemonadePrice <= 0.50 && lemonadePrice < 0.75)
            {
                if (currentTemp < 85)
                {
                    willBuy = false;
                    customerPercent = customerGenerator.Next(5);
                    if (customerPercent == 5)
                    {
                        willBuy = true;
                    }
                }
            }
            else if (lemonadePrice <= 0.75 && lemonadePrice < 1.00)
            {
                if (currentTemp < 90)
                {
                    willBuy = false;
                    customerPercent = customerGenerator.Next(6);
                    if (customerPercent == 6)
                    {
                        willBuy = true;
                    }
                }
            }
            else
            {
                if (currentTemp < 95)
                {
                    willBuy = false;
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