using System;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManufacturingSystem;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory factory = new ElectricVehicleFactory();

            factory.CreateTruck();
            factory.CreateCar();
            factory.CreateEngine();
        }
    }
}