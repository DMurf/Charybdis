using Charybdis.Core.Entities.Measures.CrossCutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Core.Entities.Measures.KS4
{
    public class SubjectEntries
    {
        public IEnumerable<SubjectEntryItem> CoreSubjects { get; set; } = default!;
        public IEnumerable<SubjectEntryItem> AdditionalSubjects { get; set; } = default!;
    }


}
