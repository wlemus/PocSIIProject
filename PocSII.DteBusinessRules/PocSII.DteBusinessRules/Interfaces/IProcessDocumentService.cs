using PocSII.DteBusinessRules.Common;
using PocSII.DteBusinessRules.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteBusinessRules.Interfaces
{
    public interface IProcessDocumentService
    {
        Task<Result<DTEResultSendDTO>> SendTaxService(InvoiceDTO factura);
        Task<Result<bool>> NotifySubmission(InvoiceDTO factura);
    }
}
