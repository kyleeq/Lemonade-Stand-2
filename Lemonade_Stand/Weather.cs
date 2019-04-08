using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Weather
    {
        // member variables 
        private static Random rand = new Random();        
        private int currentWeather;

        // constructor

        // member methods
        public void GoodWeatherDeterminator()
        {
            bool isGoodWeather = rand.Next(0, 2) > 0; 
            if (isGoodWeather == true)
            {
                Console.WriteLine("The forecasted weather is sunny");
            }
            else
            {
                Console.WriteLine("The forecasted weather is rainy");
            }            
        }
        public void TempDeterminator()
        {
            double weatherTemp = rand.Next(60, 95);
        }
    }
}