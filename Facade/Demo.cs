using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Demo
    {
        public static void Main()
        {
            var amp = new Amplifier();
            var dvd = new DvdPlayer();
            var tuner = new Tuner();
            var cd = new CdPlayer();
            var projector = new Projecter();
            var screen = new Screen();
            var lights = new TheaterLights();
            var popper = new PopcornPopper();

            var facade = new HomeTheaterFacade(
                amp, tuner, dvd, cd, projector, screen, lights, popper);

            facade.WatchMovie("Star Wars");
        }
    }
}
