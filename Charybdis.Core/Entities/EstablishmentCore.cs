using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Core.Entities
{
    public class EstablishmentCore
    {
        public int EstablishmentNumber { get; set; } = default!;
        public string EstablishmentName { get; set; } = default!;
        public string EstablishmentNameUrlFriendly => EstablishmentName.Replace(" ", "-");
        public string TrustName { get; set; } = default!;
        public string Website { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Telephone { get; set; } = default!;
        public string FullAddress { get; set; } = default!;
        public string Easting { get; set; } = default!;
        public string Northing { get; set; } = default!;


        public int LocalAuthorityCode { get; set; } = default!;
        public string LocalAuthorityName { get; set; } = default!;

        public int EstablishmentTypeCode { get; set; } = default!;
        public string EstablishmentTypeName { get; set; } = default!;

        public int EstablishmentGroupCode { get; set; } = default!;
        public string EstablishmentGroupName { get; set; } = default!;

        public string HeadTeacherName { get; set; } = default!;
        public string AgeRange { get; set; } = default!;

        public int StatutoryLowAge { get; set; } = default!;
        public int StatutoryHighAge { get; set; } = default!;

        public int GenderCode { get; set; } = default!;
        public string GenderName { get; set; } = default!;


        public int ReligiousCharacterCode { get; set; } = default!;
        public string ReligiousCharacterName { get; set; } = default!;
        
        public int EstablishmentStatusCode { get; set; } = default!;
        public string EstablishmentStatusName { get; set; } = default!;

        public int PhaseCode { get; set; } = default!;
        public string PhaseName { get; set; } = default!;

        public int SixthFormCode { get; set; } = default!;
        public string SixthFormName { get; set; } = default!;

        public int TotalPupilNumber { get; set; } = default!;



        public EstablishmentCore() { }
    }
}
