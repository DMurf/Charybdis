using Charybdis.Core.Entities.DTOs;
using Charybdis.Core.Interfaces.Repositories;
using Charybdis.Infrastructure.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Infrastructure.Repositories
{
    public class GIASRepository : IGIASRepository
    {
        private readonly IGenericRepository _genericCSVRepository;
        private readonly string _filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Files\edubasealldata20250813.csv");

        public GIASRepository(IGenericRepository genericCSVRepository)
        {
            _genericCSVRepository = genericCSVRepository;
        }
        public IEnumerable<GIASDataModel> GetRecords()
        {
            return _genericCSVRepository.GetRecords<GIASDataModel>(_filePath);
        }
    }
}
