using PocSII.DteAPIApplicacion.Models;
using PocSII.DteBusinessRules.Common;
using PocSII.DteBusinessRules.Dto;
using System.ComponentModel;
using System.Threading.Tasks;

namespace PocSII.DteAPIApplicacion.Interfaces
{
   public interface INonSQLRepository {
        Task<DocumentoNonSQLEntity> Insert(string itemId, string item,string container, string partition);
        Task<bool> ExistItemId(string itemId, string container, string partition);
        Task<DocumentoNonSQLEntity> Get(string itemId, string container, string partition);
        Task<DocumentoNonSQLEntity> Update(string itemId, string item, string container, string partition);
    }
}
