
using FacadePattern.Components;
using FacadePattern.Facades;

var homeTheater = new HomeTheaterFacade
(new Amplifier(),
    new Tuner(),
    new StreamingPlayer(),
    new Projector(),
    new Screen(),
    new TheaterLights(),
    new PopcornPopper());
    
homeTheater.WatchMovie("Raiders of the Lost Ark");
Console.WriteLine();
Console.WriteLine();

homeTheater.EndMovie();