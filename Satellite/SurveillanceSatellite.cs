using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RocketLauncher
{
    public sealed class SurveillanceSatellite : Satellite
    {
            
        public SurveillanceSatellite(int id, string name,int weight)
        {
            this.SatelliteId = id;
            this.SatelliteName = name;
            this.SatelliteWeight = weight;
            Console.WriteLine(" Surveillance Satellite ready to use ");

        }
        

        public override void SatelliteWork()
        {
            Console.WriteLine(" Do Surveillance ");
        }
    }
}
