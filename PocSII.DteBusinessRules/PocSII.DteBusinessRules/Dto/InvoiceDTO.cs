using PocSII.DteBusinessRules.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteBusinessRules.Dto
{
    public class InvoiceDTO
    {
        public string ID { get; set; }  // Número de la Factura
        public Invoice  Factura { get; set; } // Objeto de la Factura
        public CompanyDTO Emisor { get; set; } // Empresa Emisora
        public CompanyDTO Receptor { get; set; } // Empresa Receptora
        public ResolutionDTO Resolucion { get; set; } // Información de la resolución de la factura
        public FoliosInfoDTO FoliosInfo { get; set; }
        public ElectronicStamp TimbreElectronicoInfo { get; set; }
        public DateTime FechaFirmaDoc { get; set; }
    }

  
public class ResolutionDTO {
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
    }
    public class FoliosInfoDTO {
public string FolioInicial { get; set; }
        public string FolioFinal { get; set; }
        public DateTime FechaAutorizacion { get; set; }
       
    }
    public class ElectronicStamp {
        public string LlavePublicaModuloRSA { get; set; }
        public string LlavePublicaExponenteRSA { get; set; }

        protected string LlavePrivadaModuloRSA { get; set; }
        protected string LlavePrivadaExponenteRSA { get; set; }
        public string IdLlavePublica { get; set; }
        public string FirmaDigitalDatosAutorizacion { get; set; }
        public DateTime FechaFirmaDigitalDatosAutorizacion { get; set; }
        public string FirmaDigitalDatoDocumento { get; set; }
        public DateTime FechaFirmaDigitalDatoDocumento { get; set; }
    }
}
