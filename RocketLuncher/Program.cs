using Common;
using OrbitalDevice;
using Rocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLuncher
{
    class Program
    {
        static void Main(string[] args)
        {

            SatelliteFactory factory = new SatelliteFactory();

            // Create satellite based on category 1. Surveillence 2. Map 3. weather
            var satellite1 = factory.CreateSatellite(1);

            // Check satellite
            satellite1.SatelliteWork();

            // Upgrade satellite
            satellite1.UpGradeSatellite(123, "Military Satellite", 600);
            var satellite2 = factory.CreateSatellite(2);
            satellite2.UpGradeSatellite(1213, "Map Satellite", 600);
            satellite2.SatelliteWork();
            var satellite3 = factory.CreateSatellite(3);
            satellite3.UpGradeSatellite(1223, "Weather Satellite", 600);
            satellite3.SatelliteWork();

            // Create rocket
            Pslv rocketObj = new Pslv(001, "PSLV", 2000,"Mars");

            // Add satellites
            rocketObj.AddSatellite(satellite1);
            rocketObj.AddSatellite(satellite2);
            rocketObj.AddSatellite(satellite3);

            // Get satellite counts
            rocketObj.GetSatelliteCount();

            // Change destination
            rocketObj.ChangeDestination("Jupiter");
            rocketObj.DetachSatellite(satellite2);
            rocketObj.AddSatellite(satellite1);
            rocketObj.GetSatelliteDetails();

            Console.Read();
        }
    }
}
