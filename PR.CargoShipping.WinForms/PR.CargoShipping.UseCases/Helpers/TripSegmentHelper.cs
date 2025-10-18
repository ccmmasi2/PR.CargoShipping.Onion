using PR.CargoShipping.CoreBusiness;
using PR.CargoShipping.UseCases.ViewModels;

namespace PR.CargoShipping.UseCases.Helpers
{
    public class TripSegmentHelper
    {
        internal static List<TripSegmentViewModel> ProcessSegments(List<TripSegment> listSegments)
        {
            if (listSegments == null || listSegments.Count <= 0)
                return new List<TripSegmentViewModel>();

            return listSegments.Select(x =>
            {
                decimal? actualHours = null;
                decimal? sailingVariance = null;
                bool warning = false;

                if (!x.IsTimeValid)
                    throw new ApplicationException($"Segment start time and/or end Time of trip {x.TripNumber} are invalid");

                if (x.StartDateTime.HasValue && x.EndDateTime.HasValue)
                {
                    actualHours = (x.EndDateTime - x.StartDateTime).Value.Hours;

                    sailingVariance = actualHours - x.StandardHours;

                    if (sailingVariance.HasValue && sailingVariance / x.StandardHours > (decimal)0.1)
                        warning = true;
                }

                return new TripSegmentViewModel
                {
                    TripNumber = x.TripNumber,
                    StartPort = x.StartPort,
                    EndPort = x.EndPort,
                    StandardHours = x.StandardHours,
                    SailingSequence = x.SailingSequence,
                    ActualHours = actualHours,
                    StartDateTime = x.StartDateTime?.ToString("MM/dd/yyyy hh:mm tt") ?? string.Empty,
                    EndDateTime = x.EndDateTime?.ToString("MM/dd/yyyy hh:mm tt") ?? string.Empty,
                    VarianceWarning = warning
                };
            }).ToList();
        }
    }
}
