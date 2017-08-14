using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class DvdPlayer
    {
        public void on()
        {
            Debug.WriteLine("Dvd player on.");
        }

        public void off()
        {
            Debug.WriteLine("Dvd player off.");
        }

        public void eject()
        {
            Debug.WriteLine("Dvd player eject.");
        }

        public void pause()
        {
            Debug.WriteLine("Dvd player paused.");
        }

        public void play()
        {

        }

        public void play(string movie)
        {
            Debug.WriteLine("Dvd playing " + movie + ".");
        }

        public void setStereoAudio()
        {
            Debug.WriteLine("Dvd player stereo audio set.");
        }

        public void setTwoChannelAudio()
        {
            Debug.WriteLine("Dvd player two channel audio set.");
        }

        public void stop()
        {
            Debug.WriteLine("Dvd player stopped.");
        }
    }
}
