using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Amplifier
    {
        public void on()
        {
            Debug.WriteLine("Amplifier on.");
        }

        public void off()
        {

        }

        public void setCd()
        {

        }

        public void setDvd(DvdPlayer dvd)
        {
            Debug.WriteLine("Amplifier dvd set.");
        }

        public void setStereoSound()
        {

        }

        public void setSurroundSound()
        {
            Debug.WriteLine("Amplifier surround sound set.");
        }

        public void setTuner()
        {

        }

        public void setVolume(int volume)
        {
            Debug.WriteLine("Amplifier volume set to " + volume + ".");
        }
    }
}
