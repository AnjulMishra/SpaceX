using OrbitalDevice;

namespace Rocket
{
    public interface ICarrier
    {
        void AddSatellite(Satellite satellite);
        int GetSatelliteCount();
        void DetachSatellite(Satellite s);
        void GetSatelliteDetails();

    }
}
