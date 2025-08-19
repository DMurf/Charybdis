using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Core.Entities.Measures.CrossCutting
{
    public class SubjectEntryItem(string subject, string qualification, int numberOfEntries)
    {
        public string Subject { get; set; } = subject;
        public string Qualification { get; set; } = qualification;
        public int NumberOfEntries { get; set; } = numberOfEntries;
    }
}

