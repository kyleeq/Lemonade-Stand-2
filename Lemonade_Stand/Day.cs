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
            
            customers = new List<Customer>();
            GenerateCustomers();
        }

        //member methods    
        public void DayKickOff(Player player)
        {
            double initialBank = player.bank;
                       
            if (UserInterface.RecipeStatement() == true)
            {
                player.recipe.SetRecipe();
            }
            UserInterface.ForecastedWeatherStatement(weather);
            if (UserInterface.StoreStatement() == true)
            {
                store.GoToStore(player);
            }
            UserInterface.CurrentWeatherStatement(weather);
            foreach (Customer customer in customers)
            {
                if (customer.PricePointDeterminant(player.recipe.lemonadePrice, weather.CurrentTemp) == true)
                {
                    player.sellCup++;
                }
            }
            Console.WriteLine($"You sold {player.sellCup} cups. You made {player.bank - initialBank} dollars.");
            UserInterface.DisplayInventory(player.inventory);
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