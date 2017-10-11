using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RocketLauncher
{
    public abstract class Satellite
    {
       public int SatelliteId { get; set; }
       public string SatelliteName { get; set; }
       public int SatelliteWeight { get; set; }
       
       public abstract void SatelliteWork();       
    }
}
