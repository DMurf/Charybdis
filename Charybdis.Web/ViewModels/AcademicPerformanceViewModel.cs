using Charybdis.Core.Entities;
using Charybdis.Core.Entities.Measures.KS4;

namespace Charybdis.Web.ViewModels
{
    public class AcademicPerformanceViewModel
    {
        public EstablishmentMetadata EstablishmentMetadata { get; set; } = default!;

        public Grade5EngMath KS4_Grade5EngMath { get; set; } = default!;

        public SubjectEntries KS4_SubjectEntries { get; set; } = default!;

        public Destinations KS4_Destinations { get; set; } = default!;
    }
}
