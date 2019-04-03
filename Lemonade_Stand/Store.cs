using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Store
    {
        // member variables
        private int lemonPrice;
        private int sugarPrice;                        
        private int paperCupsPrice;
        private int icePrice;

        private int lemonsBought; // on a given day
        private int sugarBought;
        private int cupsBought;
        private int iceCubesBought;

        // constructor

        // member methods
        public void GoToStore()
        {
            Console.WriteLine("Let's go to the store and purchase some ingrediants for your lemonade.");
            Console.WriteLine("Enter how many lemons would you like to buy");
            lemonsBought = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many cups of sugar you would like to buy");
            sugarBought = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many paper cups you would like to buy");
            cupsBought = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many ice cubs you would like to buy");
            iceCubesBought = Convert.ToInt32(Console.ReadLine());
        }
    }

}