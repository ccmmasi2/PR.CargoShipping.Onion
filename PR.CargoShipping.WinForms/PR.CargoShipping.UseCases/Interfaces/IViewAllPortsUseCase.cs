using PR.CargoShipping.CoreBusiness;

namespace PR.CargoShipping.UseCases.Interfaces
{
    public interface IViewAllPortsUseCase
    {
        List<Port> Execute();
    }
}
