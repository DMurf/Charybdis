using Charybdis.Core.Entities;

namespace Charybdis.Core.Interfaces.Repositories
{
    public interface IGIASRepository
    {
        IEnumerable<EstablishmentMetadata> GetRecords();
    }
}