using OrbitalDevice;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rocket
{
    public sealed class Pslv : ICarrier
    {

        private ICollection<Satellite> _satellites = null;
        public int RocketId { get; set; }
        public string RocketName { get; set; }
        public int Capacity { get; set; }

        public string Destination { get; set; }
        public ICollection<Satellite> satellites
        {
            get => _satellites ?? (_satellites = new List<Satellite>());
            private set => _satellites = value;
        }
        public Pslv(int id, string name, int capacity,string destination)
        {
            RocketId = id;
            RocketName = name;
            Capacity = capacity;
            Destination = destination;
            Console.WriteLine(" Launch vechile {0} is ready to use", this.RocketName);
            Console.WriteLine("\n");
        }

        public void AddSatellite(Satellite satellite)
        {
            int CapacityLeft = WeightExceeded();
            if (satellite.SatelliteWeight <= CapacityLeft)
            {                
                satellites.Add(satellite);
            }
            else
            {
                //log 
                Console.WriteLine("Satellite weight exceeds permisible weight !");
                Console.WriteLine("\n");
            }
        }

        public int GetSatelliteCount()
        {
            return satellites.Count();
        }

        public void DetachSatellite(Satellite satellite)
        {
            satellites.Remove(satellite);
            Console.WriteLine("Satellite detached from rocket successfully");
        }

        public void GetSatelliteDetails()
        {
            foreach(Satellite s in satellites)
            {
                Console.WriteLine("Satellite id = {0}", s.SatelliteId);
                Console.WriteLine("Satellite Name = {0}", s.SatelliteName);
                Console.WriteLine("Satellite Weight = {0}", s.SatelliteWeight);
                Console.WriteLine("\n");
            }
        }

        private int WeightExceeded()
        {
            int totalwieght = 0;
            foreach (var s in satellites)
            {
                totalwieght += s.SatelliteWeight;
            }
            return Capacity - totalwieght;
        }
    }
}
