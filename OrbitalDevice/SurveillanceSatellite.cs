using System;

namespace OrbitalDevice
{
    public sealed class SurveillanceSatellite : Satellite
    {     
        public override void SatelliteWork()
        {
            Console.WriteLine(" Surveillance satellite ready ");
            Console.WriteLine("\n");
        }
        public override void UpGradeSatellite(int id, string name, int weight)
        {
            SatelliteId = id;
            SatelliteName = name;
            SatelliteWeight = weight;
            Console.WriteLine(" Surveillance Satellite updated ");
            Console.WriteLine("\n");
        }
    }
}
