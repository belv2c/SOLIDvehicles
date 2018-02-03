using SOLIDvehicles.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDvehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var airplane = new Airplane
            {
                Wheels = 10,
                Doors = 9,
                PassengerCapacity = 50,
                Winged = true,
                MaxAirSpeed = 500
            };

            var cessna = new Cessna
            {
                Wheels = 3,
                Doors = 3,
                PassengerCapacity = 2,
                Winged = true,
                MaxAirSpeed = 300,
                MaxWaterSpeed = 200
            };

            var motorcycle = new Motorcycle
            {
                Wheels = 2,
                PassengerCapacity = 2,
                MaxLandSpeed = 150,
            };

            var bus = new Bus
            {
                Wheels = 6,
                Doors = 4,
                PassengerCapacity = 50,
                MaxLandSpeed = 80,
                TransmissionType = "automatic",
            };

            var jetski = new JetSki
            {
                PassengerCapacity = 2,
                MaxWaterSpeed = 60,
            };

            var yacht = new Yacht
            {
                Doors = 25,
                PassengerCapacity = 100,
                TransmissionType = "manual",
                MaxWaterSpeed = 100,
                EngineVolume = 50
            };


            // Build a collection of all vehicles that operate on water
            // Build a collection of all vehicles that operate on roads
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            // With a single `foreach`, have each road vehicle Drive()
            // With a single `foreach`, have each water vehicle Drive()
        }
    }
}
