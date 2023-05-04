using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Components;

namespace FacadePattern.Facades
{
    public class HomeTheaterFacade
    {
        public Amplifier Amplifier { get; set; }
        public Tuner Tuner { get; set; }
        public StreamingPlayer StreamingPlayer { get; set; }
        public Projector Projector { get; set; }
        public Screen Screen { get; set; }
        public TheaterLights Lights { get; set; }
        public PopcornPopper Popper { get; set; }

        public HomeTheaterFacade(
            Amplifier amplifier, 
            Tuner tuner, 
            StreamingPlayer streamingPlayer, 
            Projector projector, 
            Screen screen, 
            TheaterLights lights, 
            PopcornPopper popper)
        {
            Amplifier = amplifier;
            Tuner = tuner;
            StreamingPlayer = streamingPlayer;
            Projector = projector;
            Screen = screen;
            Lights = lights;
            Popper = popper;
        }

        public void WatchMovie(string movieTitle)
        {
            Console.WriteLine("Get ready to watch a movie...");

            Popper.On();
            Popper.Pop();

            Lights.Dim(10);

            Screen.Down();

            Projector.On();
            Projector.WideScreenMode();

            Amplifier.On();
            Amplifier.SetStreamingPlayer("Blu-Ray Player");
            Amplifier.SetSurroundSound();
            Amplifier.SetVolume(5);

            StreamingPlayer.On();
            StreamingPlayer.Play(movieTitle);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the movie theater...");

            Popper.Off();
            Lights.On();
            Screen.Up();
            Projector.Off();
            Amplifier.Off();
            StreamingPlayer.Stop();
            StreamingPlayer.Off();
        }
    }
}
