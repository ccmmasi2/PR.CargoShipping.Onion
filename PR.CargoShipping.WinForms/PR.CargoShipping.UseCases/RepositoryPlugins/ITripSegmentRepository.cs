using PR.CargoShipping.CoreBusiness;

namespace PR.CargoShipping.UseCases.RepositoryPlugins
{
    public interface ITripSegmentRepository
    {
        List<TripSegment> GetTripSegmentsByTripNumber(string tripNumber);
        List<TripSegment> GetTripSegmentsByPort(int portId);
    }
}
