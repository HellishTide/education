using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherTest
{
    public class CurrentConditionsDisplay: IObserver<WeatherData>, IDisplayElement
    {
        private float temperature;
        private float humidity;
        IObservable<T>

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: {0} F degrees and {1} humidity", temperature, humidity);
        }
    }
}
