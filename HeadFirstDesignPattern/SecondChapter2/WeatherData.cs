using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SecondChapter2
{
    class WeatherData
    {
        public WeatherData(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }

        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
    }
}
