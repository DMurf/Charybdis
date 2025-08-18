using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Core.Entities.Measures
{
    public class KS4_SubjectEntries
    {
        public IEnumerable<SubjectEntries> CoreSubjects { get; set; }
        public IEnumerable<SubjectEntries> AdditionalSubjects { get; set; }
    }

    public class SubjectEntries
    {
        public SubjectEntries(string subject, string qualification, int numberOfEntries)
        {
            Subject = subject;
            Qualification = qualification;
            NumberOfEntries = numberOfEntries;
        }

        public string Subject { get; set; }
        public string Qualification { get; set; }
        public int NumberOfEntries { get; set; }
    }
}
