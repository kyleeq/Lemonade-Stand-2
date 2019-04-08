using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Game
    {
        // member variables             
        private double income;
        private double netProfitOrLoss;
        private double currentMoney; // put in Player class?
        private double cupsSold;
        public Player player;
        public Day day;
        public Store store;
        public Recipe recipe;

        // constructor
        public Game()
        {            
            income = 0;
            netProfitOrLoss = 0;
            currentMoney = 20.00;
            cupsSold = 0;
        }

        // member methods
        public void GameKickOff()
        {            
            UserInterface.InitialStatement();

        }
  
        public double DailyIncome()
        {
     
            income = cupsSold * recipe.lemonadePrice;
            return income;
        }
        public void TotalNetProfitOrLoss()
        {
            currentMoney = currentMoney + income;
        }        

        public double TotalNetWorthCalc(double currentMoney, double expenses)
        {
            currentMoney = currentMoney - expenses;
            return currentMoney;
        }              
    }
}


    