using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using UnityContainerDemo.Interfaces;

namespace UnityContainerDemo
{
    class Driver
    {
        private ICar _car = null;
        
        public Driver(ICar car)
        {
            _car = car;
        }
        public Driver(string name)
        {

        }
        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        }
    }
}
