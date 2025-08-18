using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Core.Entities.Measures
{
    public class KS4_Destinations
    {
        public string Destination_School { get; set; }
        public string Destination_LA { get; set; }
        public string Destination_NAT { get; set; }

        public string Destination_Education { get; set; }
        public string Destination_Education_LA { get; set; }
        public string Destination_Education_NAT { get; set; }

        public string Destination_Employment { get; set; }
        public string Destination_Employment_LA { get; set; }
        public string Destination_Employment_NAT { get; set; }

        public string Destination_Apprenticeships { get; set; }
        public string Destination_Apprenticeships_LA { get; set; }
        public string Destination_Apprenticeships_NAT { get; set; }

        public VisualMeasure VisualMeasure { get; set; }
    }
}
