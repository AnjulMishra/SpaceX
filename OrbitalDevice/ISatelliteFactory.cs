using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrbitalDevice
{
   public interface ISatelliteFactory
    {
       Satellite CreateSatellite(int satelliteType);
    }
}
