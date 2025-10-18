using PR.CargoShipping.CoreBusiness;

namespace PR.CargoShipping.UseCases.RepositoryPlugins
{
    public interface IPortRepository
    {
        List<Port> GetPorts();
    }
}
