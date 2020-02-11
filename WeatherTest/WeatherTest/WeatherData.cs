using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherTest
{
    public class WeatherData: ISubject
    {
        private List<IObserver> observers;
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }


        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            if (observers.Count > 0)
                observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var elemetn in observers)
                elemetn.Update(Temperature, Humidity, Pressure);
        }
        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementChanged();
        }
    }
}
