using PR.CargoShipping.UseCases.Helpers;
using PR.CargoShipping.UseCases.Interfaces;
using PR.CargoShipping.UseCases.RepositoryPlugins;
using PR.CargoShipping.UseCases.ViewModels;

namespace PR.CargoShipping.UseCases
{
    public class SearchByPortUseCase : ISearchByPortUseCase
    {
        private readonly ITripSegmentRepository tripSegmentRepository;

        public SearchByPortUseCase(ITripSegmentRepository tripSegmentRepository)
        {
            this.tripSegmentRepository = tripSegmentRepository;
        }

        public List<TripSegmentViewModel> Execute(int portId)
        {
            var listSegments = tripSegmentRepository.GetTripSegmentsByPort(portId);
            return TripSegmentHelper.ProcessSegments(listSegments);
        }
    }
}
