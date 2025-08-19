using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Core.Entities.Measures.KS4
{
    public class Destinations
    {
        public string Destination_School { get; set; } = default!;
        public string Destination_LA { get; set; } = default!;
        public string Destination_NAT { get; set; } = default!;

        public string Destination_Education { get; set; } = default!;
        public string Destination_Education_LA { get; set; } = default!;
        public string Destination_Education_NAT { get; set; } = default!;

        public string Destination_Employment { get; set; } = default!;
        public string Destination_Employment_LA { get; set; } = default!;
        public string Destination_Employment_NAT { get; set; } = default!;

        public string Destination_Apprenticeships { get; set; } = default!;
        public string Destination_Apprenticeships_LA { get; set; } = default!;
        public string Destination_Apprenticeships_NAT { get; set; } = default!;

        public VisualMeasure VisualMeasure { get; set; } = default!;
    }
}
