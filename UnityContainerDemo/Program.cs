using System;
using System.Runtime.InteropServices;
//using Microsoft.Practices.Unity;          //deze werkt niet voor mij?
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using UnityContainerDemo.Interfaces;
using UnityContainerDemo.ManufacturerKeys;
using UnityContainerDemo.Manufacturers;

namespace UnityContainerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Driver driver = new Driver(new BMW());
            //driver.RunCar();

            var container = new UnityContainer().RegisterType<ICar,BMW>(new HierarchicalLifetimeManager());

            var childContainer = container.CreateChildContainer();

            var driver1 = container.Resolve<Driver>();
            driver1.RunCar();

            var driver2 = container.Resolve<Driver>();
            driver2.RunCar();

            var driver3 = childContainer.Resolve<Driver>();
            driver3.RunCar();

            var driver4 = childContainer.Resolve<Driver>();
            driver4.RunCar();
        }
    }
}
