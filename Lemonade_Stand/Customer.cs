using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public abstract class Customer : ChildCustomer
    {
        // member variables
        private int age;
        private int sweetnessLevel;
        private int pricePreference;

        // constructor

        // member methods
        public void DetermineIfWillBuyLemonade(Weather todaysWeather, double recipePrice)
        {
            
        }
        
    }
}