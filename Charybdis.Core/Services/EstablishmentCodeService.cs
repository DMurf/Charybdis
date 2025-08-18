using Charybdis.Core.Entities;
using Charybdis.Core.Interfaces.Repositories;
using Charybdis.Core.Interfaces.Services;
using Charybdis.Infrastructure.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Core.Services
{
    public class EstablishmentCodeService : IEstablishmentCoreService
    {
        private readonly IGIASRepository _repository;

        public EstablishmentCodeService(IGIASRepository giasRepo)
        {
            _repository = giasRepo;
        }

        public EstablishmentCore GetEstablishment(int urn)
        {
            var rawData = _repository.GetRecords().FirstOrDefault(x => x.URN == urn.ToString());
            if (rawData == null)
            {
                throw new Exception($"GetEstablishment, no URN data for {urn}");
            }
            return EstablishmentGIASMapper.Map(rawData);
        }

        public IEnumerable<EstablishmentCore> GetEstablishments()
        {
            throw new NotImplementedException();
        }
    }
}
