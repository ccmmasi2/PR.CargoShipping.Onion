using Microsoft.Extensions.DependencyInjection;
using PR.CargoShipping.Plugins.Repository.ADONET;
using PR.CargoShipping.UseCases;
using PR.CargoShipping.UseCases.Interfaces;
using PR.CargoShipping.UseCases.RepositoryPlugins;

namespace PR.CargoShipping.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var frmTrips = serviceProvider.GetRequiredService<frmTrips>();
                Application.Run(frmTrips);
            }
        }

        static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<frmTrips>();

            services.AddTransient<ITripSegmentRepository, TripSegmentRepository>();
            services.AddTransient<IPortRepository, PortRepository>();

            services.AddTransient<ISearchByTripNumberUseCase, SearchByTripNumberUseCase>();
            services.AddTransient<IViewAllPortsUseCase, ViewAllPortsUseCase>();
            services.AddTransient<ISearchByPortUseCase, SearchByPortUseCase>();
        }
    }
}