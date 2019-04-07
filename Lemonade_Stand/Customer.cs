using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public abstract class Customer
    {
        // member variables     
        public double pricePreference;
        public Recipe recipe;

        // constructor
        public Customer()
        {

        }

        // member methods
        public virtual void PricePointDeterminant(double lemonadePrice)
        {

        }
        public void DetermineIfWillBuyLemonade(Weather todaysWeather, double recipePrice)
        {
            
        }
        
    }
}