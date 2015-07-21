using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingStation parkingStation = new ParkingStation();
            IVehicle bike=new Bike();
            bike.SetEntryTime(6,0);
            parkingStation.AddVehicle(bike);

            IVehicle cycle = new Bicycle();
            cycle.SetEntryTime(7, 0);
            parkingStation.AddVehicle(cycle);

            parkingStation.DisplayVehicleBills();
        }
    }
}
