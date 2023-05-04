using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Components
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Turning on the lights");
        }

        public void Off()
        {
            Console.WriteLine("Turning off the lights");
        }

        public void Dim(int level)
        {
            Console.WriteLine($"Setting the lights to {level}%");
        }


    }
}
