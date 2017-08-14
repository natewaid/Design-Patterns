using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Demo
    {
        public static void Main()
        {
            // instantiate our concrete implementations of the subject and observers
            var weatherData = new WeatherData();
            var currentConditions = new CurrentConditionsDisplay(weatherData);

            // send some new measurements to the subject
            // the subject will automatically send the updates to the observers
            // the observers will show their own individual displays with the measurements from the subject
            weatherData.setMeasurements(80, 65, 30.4);
            weatherData.setMeasurements(82, 70, 29.2);
            weatherData.setMeasurements(78, 90, 29.2);
        }
    }
}
