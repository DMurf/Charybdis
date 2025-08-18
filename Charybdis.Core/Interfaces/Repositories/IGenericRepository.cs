using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Core.Interfaces.Repositories
{
    public interface IGenericRepository
    {
        IEnumerable<T> GetRecords<T>(string path);
    }
}
