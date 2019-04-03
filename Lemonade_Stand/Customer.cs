using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public abstract class Customer : ChildCustomer
    {
        private int age;
        private int sweetnessLevel;
        private int pricePreference;

        public void DetermineIfWillBuyLemonade(Weather todaysWeather, double recipePrice)
        {
            
        }
        
    }
}