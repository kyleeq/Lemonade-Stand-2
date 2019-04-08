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
        public Store store;
        public Recipe recipe;

        // constructor
        public Game()
        {            
            income = 0;
            netProfitOrLoss = 0;
            currentMoney = 20.00;
            cupsSold = 0;
            player = new Player();
            
        }

        // member methods
        public void GameKickOff()
        {            
            UserInterface.InitialStatement();
            double initialPlayerBank = player.bank;
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day();
                day.DayKickOff(player);
            }
            Console.WriteLine($"Your total Net Profit/Loss was {player.bank - initialPlayerBank} dollars.");
            Console.ReadLine();
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


    