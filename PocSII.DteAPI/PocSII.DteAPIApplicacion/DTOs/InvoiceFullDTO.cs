using PocSII.DteBusinessRules.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteAPIApplicacion.DTOs
{
   public class InvoiceFullDTO
    {
        public InvoiceDTO DTE { get; set; }
        public DTEResultSendDTO respuestaSII { get; set; }
    }
}
