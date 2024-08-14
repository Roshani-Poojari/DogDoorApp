using DogDoorApp.Models;

namespace DogDoorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Remote remote = new Remote(new DogDoor());
            Console.WriteLine("\nFido barks to go outside...");
            remote.PressButton();
            Console.WriteLine("\nFido has gone outside...");
            //p1  remote.PressButton();
            Console.WriteLine("\nFido's all done...");
            //remote.PressButton();
            try
            {
                Thread.Sleep(10000);
            }
            catch (Exception ex) { }
            Console.WriteLine("\n...But he's stuck outside!");
            Console.WriteLine("\nFido barks to go inside...");
            Console.WriteLine("\n...So Gina grabs the remote control.");
            remote.PressButton();
            Console.WriteLine("\nFido's back inside...");
            //p1  remote.PressButton();
        }
    }
}
/*
 Part 1 -> DogDoor class - bool _open
                         - Open() returns void
                         - Close() returns void
                         - IsOpen() returns bool
        -> Remote class  - DogDoor _door
                         - PressButton() returns void

 Part 2 -> DogDoor class - bool _open
                         - Open() returns void
                         - Close() returns void
                         - IsOpen() returns bool
        -> Remote class  - DogDoor _door
                         - PressButton() returns void
                         - Timer to close door after sometime

Prt 3 -> DogDoor class - bool _open
                         - Open() returns void
                         - Close() returns void
                         - IsOpen() returns bool
        -> Remote class  - DogDoor _door
                         - PressButton() returns void
                         - Timer to close door after sometime
        -> Program class - add try catch 
 */