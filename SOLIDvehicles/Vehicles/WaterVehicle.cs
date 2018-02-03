using System;

namespace SOLIDvehicles.Vehicles
{
    public class WaterVehicle : IVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("Vehicle is driving.");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            Console.WriteLine("Starting vehicle.");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
