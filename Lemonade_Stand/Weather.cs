﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand
{
    public class Weather
    {
        // member variables 
        private static Random randomForecast = new Random();        
        private int currentWeather;

        // constructor

        // member methods
        public void WeatherDeterminator()
        {
            bool isGoodWeather = randomForecast.Next(2); 
            if (isGoodWeather == true)
            {

            }
        }
    }
}