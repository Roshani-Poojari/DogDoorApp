using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Models
{
    internal class Remote
    {
        private DogDoor _door;
        private const int AutoCloseDelay = 5000;
        public Remote(DogDoor door)
        {
            _door = door;
        }
        public void PressButton()
        {
            Console.WriteLine("\nPressing the remote control button..");
            if (_door.IsOpen())
                _door.Close();
            else
            {
                _door.Open();
                new Thread(AutoClose).Start();
            }
        }
        private void AutoClose()
        {
            Thread.Sleep(AutoCloseDelay);
            if (_door.IsOpen()) 
            {
                _door.Close();
            }
        }
    }
}