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
        private double currentTemp;
        private double forecastedTemp;
        private bool isGoodWeather;
        private double tempDifference;

        public double ForecastedTemp
        {
            get
            {
                return forecastedTemp;
            }
        }

        // constructor
        public Weather()
        {
            forecastedTemp = rand.Next(60, 95);
            isGoodWeather = rand.Next(0, 2) > 0;                      
        }
        // member methods
        public void ForecastedWeather()
        {
            if (isGoodWeather == true)
            {
                Console.WriteLine($"The forecasted weather is {forecastedTemp} and sunny");
            }
            else
            {
                Console.WriteLine($"The forecasted weather is {forecastedTemp} and rainy");
            }
        }
        public double CurrentWeatherDeterminator()
        {
            tempDifference = rand.Next(0, 5);
            if (isGoodWeather == true)
            {
                currentTemp = forecastedTemp + tempDifference;
            }
            else
            {
                currentTemp = forecastedTemp - tempDifference;
            }
            return currentTemp;
        }
    }
}