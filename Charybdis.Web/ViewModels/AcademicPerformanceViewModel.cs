using Charybdis.Core.Entities;
using Charybdis.Core.Entities.Measures;

namespace Charybdis.Web.ViewModels
{
    public class AcademicPerformanceViewModel
    {
        public EstablishmentCore EstablishmentCore { get; set; } = default!;

        public KS4_Grade5EngMath KS4_Grade5EngMath { get; set; } = default!;

        public KS4_SubjectEntries KS4_SubjectEntries { get; set; } = default!;

        public KS4_Destinations KS4_Destinations { get; set; } = default!;
    }
}
