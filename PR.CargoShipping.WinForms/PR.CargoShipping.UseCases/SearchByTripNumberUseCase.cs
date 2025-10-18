using PR.CargoShipping.UseCases.Helpers;
using PR.CargoShipping.UseCases.Interfaces;
using PR.CargoShipping.UseCases.RepositoryPlugins;
using PR.CargoShipping.UseCases.ViewModels;

namespace PR.CargoShipping.UseCases
{
    public class SearchByTripNumberUseCase : ISearchByTripNumberUseCase
    {
        private ITripSegmentRepository tripSegmentRepository;

        public SearchByTripNumberUseCase(ITripSegmentRepository tripSegmentRepository)
        {
            this.tripSegmentRepository = tripSegmentRepository;
        }

        public List<TripSegmentViewModel> Execute(string tripNumber)
        {
            // Get Trip Segments            
            var listSegments = tripSegmentRepository.GetTripSegmentsByTripNumber(tripNumber);
            return TripSegmentHelper.ProcessSegments(listSegments);
        }
    }
}
