using System;

namespace OrbitalDevice
{
    public sealed class WeatherSatellite : Satellite
    {
        public override void SatelliteWork()
        {
            Console.WriteLine(" Weather satellite ready ");
            Console.WriteLine("\n");
        }
        public override void UpGradeSatellite(int id, string name, int weight)
        {
            SatelliteId = id;
            SatelliteName = name;
            SatelliteWeight = weight;
            Console.WriteLine(" Weather Satellite updated ");
            Console.WriteLine("\n");
        }
    }
}
