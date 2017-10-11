using System;

namespace OrbitalDevice
{
    public sealed class MapsSatellite : Satellite
    {
        public override void SatelliteWork()
        {
            Console.WriteLine(" Maps satellite ready ");
            Console.WriteLine("\n");
        }
        public override void UpGradeSatellite(int id, string name, int weight)
        {
            SatelliteId = id;
            SatelliteName = name;
            SatelliteWeight = weight;
            Console.WriteLine(" Maps Satellite updated ");
            Console.WriteLine("\n");
        }
    }
}
