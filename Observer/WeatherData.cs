using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// A concrete implementation of the subject interface.
    /// </summary>
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private double temperature;
        private double humidity;
        private double pressure;

        // create a list of observers in the constructor
        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        // register an observer
        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        // remove an observer
        public void removeObserver(IObserver o)
        {
            if (observers.Any() && observers.Contains(o))
            {
                observers.Remove(o);
            }
        }

        // notify all registered observers, call each observer's update method
        public void notifyObservers()
        {
            foreach (var o in observers)
            {
                o.update(temperature, humidity, pressure);
            }
        }

        // notify the observers when the measurements change
        public void measurementsChanged()
        {
            notifyObservers();
        }

        // set the measurements with new values and call the changed method
        public void setMeasurements(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}
