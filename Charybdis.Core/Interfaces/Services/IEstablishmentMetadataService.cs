using Charybdis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Core.Interfaces.Services
{
    public interface IEstablishmentMetadataService
    {
        IEnumerable<EstablishmentMetadata> GetEstablishments();
        EstablishmentMetadata GetEstablishment(int urn);
    }
}
