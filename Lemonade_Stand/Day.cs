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

        // constructor
        public Day()
        {
            weather = new Weather();
            customer = new Customer();
            store = new Store();
            GenerateCustomers();
        }

        //member methods    
        public void DayKickOff(Player player)
        {
            UserInterface.RecipeStatement();
            player.recipe.SetRecipe();
            UserInterface.StoreStatement();
            store.GoToStore(player);
        }
        public void GenerateCustomers()
        {
            for (int i = 0; i < 150; i++)
            {
                customers.Add(new Customer());
            }
        }
    }
}