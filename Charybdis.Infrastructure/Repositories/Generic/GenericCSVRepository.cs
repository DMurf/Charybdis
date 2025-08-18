using Charybdis.Core.Interfaces.Repositories;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charybdis.Infrastructure.Repositories.Generic
{
    public class GenericCSVRepository : IGenericRepository
    {
        public IEnumerable<T> GetRecords<T>(string path)
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<T>().ToList();
            return records;
        }
    }
}
