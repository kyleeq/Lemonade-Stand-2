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
            
        }       

        // member methods
        public void GoToStore(Player player)
        {
            lemonsBought = 0;
            sugarBought = 0;
            cupsBought = 0;
            iceCubesBought = 0;

            lemonsBought = UserInterface.BuyLemons();
            sugarBought = UserInterface.BuySugar();
            iceCubesBought = UserInterface.BuyIceCubes();
            cupsBought = UserInterface.BuyCups();
            double expense = TotalExpenseCalc();
            if (expense > player.bank)
            {
                Console.WriteLine("Oops. Looks like you don't have enough money for that purchase.");
                GoToStore(player);
            }
            else
            {
                player.bank -= expense;
                ItemsBought(player);
            }
        }
        public void ItemsBought(Player player)
        {
            player.inventory.lemonStock += lemonsBought;
            player.inventory.sugarStock += sugarBought;
            player.inventory.iceStock += iceCubesBought;
            player.inventory.cupStock += cupsBought;
        }
        public double TotalExpenseCalc()
        {           
            double expenses = lemonsBought * lemonPrice;
            expenses += sugarBought * sugarPrice;
            expenses += iceCubesBought + iceCubePrice;
            expenses += cupsBought * cupPrice;
            return expenses;
        }
    }

}