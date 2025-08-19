using Charybdis.Core.Entities;
using Charybdis.Core.Interfaces.Repositories;
using Charybdis.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Core.Services
{
    public class EstablishmentMetadataService : IEstablishmentMetadataService
    {
        private readonly IGIASRepository _repository;

        public EstablishmentMetadataService(IGIASRepository giasRepo)
        {
            _repository = giasRepo;
        }

        public EstablishmentMetadata GetEstablishment(int urn)
        {
            var rawData = _repository.GetRecords().FirstOrDefault(x => x.EstablishmentNumber == urn);
            if (rawData == null)
            {
                throw new Exception($"GetEstablishment, no URN data for {urn}");
            }
            return rawData;
        }

        public IEnumerable<EstablishmentMetadata> GetEstablishments()
        {
            throw new NotImplementedException();
        }
    }
}
