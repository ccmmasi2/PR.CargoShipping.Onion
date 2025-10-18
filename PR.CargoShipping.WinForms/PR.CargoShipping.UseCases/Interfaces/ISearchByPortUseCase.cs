using PR.CargoShipping.UseCases.ViewModels;

namespace PR.CargoShipping.UseCases.Interfaces
{
    public interface ISearchByPortUseCase
    {
        List<TripSegmentViewModel> Execute(int portId);
    }
}
