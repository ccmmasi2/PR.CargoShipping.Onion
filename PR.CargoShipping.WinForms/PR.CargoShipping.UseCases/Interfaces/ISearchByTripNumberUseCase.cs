using PR.CargoShipping.UseCases.ViewModels;

namespace PR.CargoShipping.UseCases.Interfaces
{
    public interface ISearchByTripNumberUseCase
    {
        List<TripSegmentViewModel> Execute(string tripNumber);
    }
}
