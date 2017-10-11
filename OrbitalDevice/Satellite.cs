using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrbitalDevice
{
    public abstract class Satellite
    {
        public int SatelliteId { get; set; }
        public string SatelliteName { get; set; }
        public int SatelliteWeight { get; set; }

        public abstract void SatelliteWork();
        public abstract void UpGradeSatellite(int id, string name, int weight);

    }
}
