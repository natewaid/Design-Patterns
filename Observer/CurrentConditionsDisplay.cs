using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// A concrete implentation of the observer interface.
    /// </summary>
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double temperature;
        private double humidity;
        private ISubject weatherData;

        // we pass in a subject object in the constructor
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            // initialize to the local variable
            this.weatherData = weatherData;

            // register this class as an observer with the subject passed in
            weatherData.registerObserver(this);
        }

        // implement the update method of the observer interface.
        public void update(double temperature, double humidity, double pressure)
        {
            // set variables that will be displayed by this observer
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

        // implement the display method of the displayelement interface.
        public void display()
        {
            Debug.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity.");
        }
    }
}
