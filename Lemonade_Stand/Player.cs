using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Player
    {
        // member variables
        private double expenses;
        private double income;
        private double netProfitOrLoss;
        private double currentMoney;

        // constructor
        public Player()
        {
            expenses = 0;
            income = 0;
            netProfitOrLoss = 0;
            currentMoney = 20.00;
        }

        // member methods
        public void 
        public double TotalNetWorthCalc(double currentMoney, double expenses)
        {
            currentMoney = currentMoney - expenses;
            return currentMoney;
        }
        public Inventory Inventory
        {
            get => default(Inventory);
            set
            {
            }
        }

        public Recipe Recipe
        {
            get => default(Recipe);
            set
            {
            }
        }
    }
}