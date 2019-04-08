using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Day
    {
        // member variables
        public Weather weather;
        public Customer customer;
        public Store store;
        public List<Customer> customers;

        public int customerList;

        // constructor
        public Day()
        {
            weather = new Weather();
            customer = new Customer();
            store = new Store();
            customers = new List<Customer>();
        }

        //member methods    
        public void DayKickOff(Player player)
        {
            UserInterface.RecipeStatement();
            player.recipe.SetRecipe();
            UserInterface.StoreStatement();
            UserInterface.BuyLemons();
            UserInterface.BuySugar();
            UserInterface.BuyIceCubes();
            UserInterface.BuyCups();
        }
    }
}