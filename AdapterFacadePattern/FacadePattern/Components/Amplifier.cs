using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Components
{
    public class Amplifier
    {
        public Tuner Tuner { get; set; }
        public StreamingPlayer Player { get; set; }

        public void On()
        {
            Console.WriteLine("Turning on the amp");
        }

        public void Off()
        {
            Console.WriteLine("Turning off the amp");
        }

        public void SetStreamingPlayer(string deviceName)
        {
            Console.WriteLine($"Setting player to {deviceName} mode");
        }

        public void SetStereoSound()
        {

        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Surround sound on (5 speakers, 1 subwoofer");
        }

        public void SetTuner()
        {
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"Setting volume to level: {level}");
        }

    }
}
