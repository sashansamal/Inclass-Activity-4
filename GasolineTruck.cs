using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace VehicleManufacturingSystem
{
    public class GasolineTruck : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle: Gasoline Truck");
        }
    }
}