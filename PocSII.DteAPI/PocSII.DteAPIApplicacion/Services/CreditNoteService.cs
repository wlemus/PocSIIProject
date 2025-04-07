using PocSII.DteAPIApplicacion.Services.Interfaces;
using PocSII.DteBusinessRules.Common;
using PocSII.DteBusinessRules.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteAPIApplicacion.Services
{
    public class CreditNoteService : IDocumentService {
        public Task<Result<object>> GetAsync(string folio) {
            throw new NotImplementedException();
        }

        public Task<Result<bool>> NotifyAsync(string folio) {
            throw new NotImplementedException();
        }

        Task<Result<string>> IDocumentService.SendAsync(ElectronicDocument documentoElectronico) {
            throw new NotImplementedException();
        }
    }
}
