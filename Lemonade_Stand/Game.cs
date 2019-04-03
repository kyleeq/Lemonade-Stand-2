using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Game
    {
        // member variables
        private double expenses;
        private double income;
        private double netProfitOrLoss;
        private double currentMoney;
        private double cupsSold;     

        // constructor
        public Game()
        {
            expenses = 0;
            income = 0;
            netProfitOrLoss = 0;
            currentMoney = 20.00;
            cupsSold = 0;
        }

        // member methods
        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }
        public void DailyIncome()
        {
            //income = cupsSold * lemonadePrice;
        }
        public void TotalNetProfitOrLoss()
        {
            currentMoney = currentMoney + income;
        }
        public void TotalExpensesCalc()
        {

        }

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
        public Day Day
        {
            get => default(Day);
            set
            {
            }
        }

        public Store Store
        {
            get => default(Store);
            set
            {
            }
        }        
    }
}


    