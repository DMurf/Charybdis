using Charybdis.Core.Entities;
using Charybdis.Core.Entities.Measures;

namespace Charybdis.Web.ViewModels
{
    public class AcademicPerformanceViewModel
    {
        public EstablishmentCore EstablishmentCore { get; set; }

        public KS4_Grade5EngMath KS4_Grade5EngMath { get; set; }

        public KS4_SubjectEntries KS4_SubjectEntries { get; set; }

        public KS4_Destinations KS4_Destinations { get; set; }
    }
}
