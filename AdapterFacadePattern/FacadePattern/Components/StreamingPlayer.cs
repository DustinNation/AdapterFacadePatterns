using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Components
{
    public class StreamingPlayer
    {
        public Amplifier Amp { get; set; }

        public void On()
        {
        }

        public void Off()
        {
            Console.WriteLine("Turned off the Streaming Player");
        }

        public void Pause(){}

        public void Play(string title)
        {
            Console.WriteLine($"Playing {title}");
        }

        public void SetSurroundSound()
        {
            
        }

        public void SetTwoChannelAudio()
        {
        }

        public void Stop()
        {
            Console.WriteLine($"Stopped streaming media");
        }


    }
}
