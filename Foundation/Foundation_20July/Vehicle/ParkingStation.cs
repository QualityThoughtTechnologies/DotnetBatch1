using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class ParkingStation
    {
        IList<IVehicle> vehicles = new List<IVehicle>(1);

        public void AddVehicle(IVehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void DisplayVehicleBills()
        {
            foreach(IVehicle vehicle in vehicles)
            {
                Console.WriteLine(" The Parking amount is " + vehicle.GetParkingAmount(14, 50));
            }
        }
    }
}
