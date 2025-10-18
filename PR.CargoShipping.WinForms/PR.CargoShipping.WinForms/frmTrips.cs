using PR.CargoShipping.CoreBusiness;
using PR.CargoShipping.UseCases.Interfaces;
using PR.CargoShipping.UseCases.ViewModels;

namespace PR.CargoShipping.WinForms
{
    public partial class frmTrips : Form
    {
        private readonly ISearchByTripNumberUseCase searchByTripNumberUseCase;
        private readonly IViewAllPortsUseCase viewAllPortsUseCase;
        private readonly ISearchByPortUseCase searchByPortUseCase;

        public frmTrips(
            ISearchByTripNumberUseCase getTripSegmentByTripNumberUseCase,
            IViewAllPortsUseCase viewAllPortsUseCase,
            ISearchByPortUseCase searchByPortUseCase)
        {
            InitializeComponent();

            this.searchByTripNumberUseCase = getTripSegmentByTripNumberUseCase;
            this.viewAllPortsUseCase = viewAllPortsUseCase;
            this.searchByPortUseCase = searchByPortUseCase;
        }

        private void frmTrips_Load(object sender, EventArgs e)
        {
            listPorts.ValueMember = "PortId";
            listPorts.DisplayMember = "Name";

            var ports = viewAllPortsUseCase.Execute();
            listPorts.DataSource = ports;
        }

        private void btnSearchByTripNumber_Click(object sender, EventArgs e)
        {
            var segments = searchByTripNumberUseCase.Execute(txtTripNumber.Text);
            gvTrips.DataSource = segments;
        }

        private void btnSearchByPort_Click(object sender, EventArgs e)
        {
            var trips = searchByPortUseCase.Execute(((Port)listPorts.SelectedItem).PortId);
            gvTrips.DataSource = trips;
        }

        private void gvTrips_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!gvTrips.Columns.Contains("Warning"))
            {
                var warningColumn = new DataGridViewButtonColumn
                {
                    Text = "Warning",
                    Name = "Warning",
                    Width = 140
                };
                gvTrips.Columns.Add(warningColumn);
            }
            if (gvTrips.Columns.Contains("VarianceWarning"))
            {
                gvTrips.Columns.Remove("VarianceWarning");
            }
        }
    }
}
