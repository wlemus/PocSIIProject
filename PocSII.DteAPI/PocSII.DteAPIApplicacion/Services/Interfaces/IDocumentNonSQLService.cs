using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteAPIApplicacion.Services.Interfaces
{
    public interface IDocumentNonSQLService<T> where T : class {
        Task<bool> Insert(string itemId, T item, string container, string partition);
        Task<T> Get(string itemId, string container, string partition);
        Task<bool> Update(string itemId, T item, string container, string partition);
        Task<bool> ExistItemId(string itemId, string container, string partition);
    }
}
