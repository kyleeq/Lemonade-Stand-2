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

        public double CurrentTemp
        {
            get
            {
                return currentTemp;
            }
        }
        public bool IsGoodWeather
        {
            get
            {
                return isGoodWeather;
            }
        }
        public double ForecastedTemp
        {
            get
            {
                return forecastedTemp;
            }
        }
        public string WeatherQuality
        {
            get
            {
                if (isGoodWeather == true)
                {
                    return "sunny";
                }
                else
                {
                    return "rainy";
                }
            }
        }

        // constructor
        public Weather()
        {
            forecastedTemp = rand.Next(70, 95);
            isGoodWeather = rand.Next(0, 2) > 0;                      
        }
        // member methods        
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