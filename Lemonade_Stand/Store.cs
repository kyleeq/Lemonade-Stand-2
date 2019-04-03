using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Store
    {
        // member variables
        private double lemonPrice;
        private double sugarPrice;                        
        private double cupPrice;
        private double iceCubePrice;

        private int lemonsBought; // on a given day
        private int sugarBought;
        private int cupsBought;
        private int iceCubesBought;

        private double expenses;

        // constructor
        public Store()
        {
            lemonPrice = 0.50;
            sugarPrice = 0.15;
            cupPrice = 0.10;
            iceCubePrice = 0.05;

            lemonsBought = 0;
            sugarBought = 0;
            cupsBought = 0;
            iceCubesBought = 0;

            expenses = 0;
        }       

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

        public void TotalExpenseCalc()
        {
            expenses = (lemonsBought * lemonPrice);
            expenses += (sugarBought * sugarPrice);
            expenses += (cupsBought * cupPrice);
            expenses += (iceCubesBought + iceCubePrice);
        }
    }

}