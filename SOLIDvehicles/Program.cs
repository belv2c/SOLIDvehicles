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
            var airplane = new AirVehicle
            {
                Wheels = 10,
                Doors = 9,
                PassengerCapacity = 50,
                Winged = true,
                MaxAirSpeed = 500
            };

            var cessna = new AirVehicle
            {
                Wheels = 3,
                Doors = 3,
                PassengerCapacity = 2,
                Winged = true,
                MaxAirSpeed = 300,
                MaxWaterSpeed = 200
            };

            var motorcycle = new LandVehicle
            {
                Wheels = 2,
                PassengerCapacity = 2,
                MaxLandSpeed = 150,
            };

            var bus = new LandVehicle
            {
                Wheels = 6,
                Doors = 4,
                PassengerCapacity = 50,
                MaxLandSpeed = 80,
                TransmissionType = "automatic",
            };

            var jetski = new WaterVehicle
            {
                PassengerCapacity = 2,
                MaxWaterSpeed = 60,
            };

            var yacht = new WaterVehicle
            {
                Doors = 25,
                PassengerCapacity = 100,
                TransmissionType = "manual",
                MaxWaterSpeed = 100,
                EngineVolume = 50
            };


            // Build a collection of all vehicles that operate on water
            var airVehicles = new List<AirVehicle>();
            airVehicles.Add(airplane);
            airVehicles.Add(cessna);

            // Build a collection of all vehicles that operate on roads  
            var landVehicles = new List<LandVehicle>();
            landVehicles.Add(motorcycle);
            landVehicles.Add(bus);

            // Build a collection of all vehicles that fly
            var waterVehicles = new List<WaterVehicle>();
            waterVehicles.Add(jetski);
            waterVehicles.Add(yacht);

            // With a single `foreach`, have each vehicle Fly()
            // With a single `foreach`, have each water vehicle Drive()
            // With a single `foreach`, have each road vehicle Drive()
        }
    }
}
