using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherTest
{
    public class WeatherData: IObservable<ISubject>, IObserver
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherData(){ }

        public void MeasurementChanged()
        {
            
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementChanged();
        }
    }
}
