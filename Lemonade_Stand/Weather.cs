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
        public void WeatherForecastDeterminator()
        {
            double weatherTemp = rand.Next(60, 95);
            bool isGoodWeather = rand.Next(0, 2) > 0; 
            if (isGoodWeather == true)
            {
                Console.WriteLine($"The forecasted weather is {weatherTemp} and sunny");
            }
            else
            {
                Console.WriteLine($"The forecasted weather is {weatherTemp} and rainy");
            }           
        }
        public void CurrentWeatherDeterminator()
        {
            
        }
    }
}