using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteAPIApplicacion.Enumerables {
    enum DocumentContainer
    {
        [Description("Factura")]
        Invoice,

        [Description("NotaCredito")]
        CreditNote
    }
}
