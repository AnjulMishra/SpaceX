using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RocketLauncher
{
    public class SatelliteFactory : ISatelliteFactory
    {
        public Satellite CreateSatellite(int satelliteType)
        {
            Satellite satelliteObj = null;

            switch (satelliteType)
            {
                case 1:
                    satelliteObj = new SurveillanceSatellite(123,"Military Surveillance",500);
                    break;
                //case 2:
                //    satelliteObj = new MapsSatellite();
                //    break;
                //case 3:
                //    satelliteObj = new WeatherSatellite();
                //    break;
            }
            return satelliteObj;
        }
    }
}
