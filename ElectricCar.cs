using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManufacturingSystem
{
    public class ElectricCar : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("electric car.");
        }
    }
}