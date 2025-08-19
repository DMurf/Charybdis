using Charybdis.Core.Entities;
using Charybdis.Infrastructure.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Infrastructure.Entities.Mappers
{
    public class EstablishmentGIASMapper
    {
        public static EstablishmentMetadata Map(GIASDataModel gias)
        {
            return new EstablishmentMetadata
            {
                AgeRange = $"{gias.StatutoryLowAge} to {gias.StatutoryHighAge}",
                StatutoryHighAge = int.Parse(gias.StatutoryHighAge),
                StatutoryLowAge = int.Parse(gias.StatutoryLowAge),
                SixthFormCode = int.Parse(gias.OfficialSixthFormcode),
                SixthFormName = gias.OfficialSixthFormname,
                Easting = gias.Easting,
                FullAddress = string.Join(", ", (new[] { gias.Street, gias.Locality, gias.Address3, gias.Town, gias.Countyname, gias.Postcode }).Where(x => !string.IsNullOrEmpty(x))),
                LocalAuthorityCode = int.Parse(gias.LAcode), 
                LocalAuthorityName = gias.LAname,
                Email = string.Empty,
                EstablishmentGroupCode = int.Parse(gias.EstablishmentTypeGroupcode),
                EstablishmentGroupName = gias.EstablishmentTypeGroupname,
                EstablishmentName = gias.EstablishmentName,
                EstablishmentNumber = int.Parse(gias.URN),
                EstablishmentStatusCode = int.Parse(gias.EstablishmentStatuscode),
                EstablishmentStatusName = gias.EstablishmentStatusname,
                EstablishmentTypeCode = int.Parse(gias.EstablishmentTypeGroupcode),
                EstablishmentTypeName = gias.EstablishmentTypeGroupname,
                GenderCode = int.Parse(gias.Gendercode),
                GenderName = gias.Gendername,
                HeadTeacherName = string.Join(" ", (new[] {gias.HeadTitlename, gias.HeadFirstName, gias.HeadLastName}).Where(x => !string.IsNullOrEmpty(x))),
                Northing = gias.Northing,
                PhaseCode = int.Parse(gias.PhaseOfEducationcode),
                PhaseName = gias.PhaseOfEducationname,
                ReligiousCharacterCode = int.Parse(gias.ReligiousCharactercode),
                ReligiousCharacterName = gias.ReligiousCharactername,
                Telephone = gias.TelephoneNum,
                TrustName = gias.Trustsname,
                Website = gias.SchoolWebsite,
                TotalPupilNumber = int.Parse(gias.NumberOfPupils)
            };
        }
    }
}
