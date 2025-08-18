using Charybdis.Core.Entities.DTOs;

namespace Charybdis.Core.Interfaces.Repositories
{
    public interface IGIASRepository
    {
        IEnumerable<GIASDataModel> GetRecords();
    }
}