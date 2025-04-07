using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteBusinessRules.Dto
{
    public class CompanyDTO {
        public string Rut { get; set; }  // RUT de la Empresa
        public string RazonSocial { get; set; }  // Nombre o Razón Social de la Empresa
        public string Giro { get; set; }  // Giro Comercial de la Empresa
        public List<string> Telefonos { get; set; } = new List<string>();  // Teléfono(s) de la Empresa
        public string CorreoElectrónico { get; set; }  // Correo Electrónico de la Empresa
        public List<string> Acteco { get; set; } = new List<string>();  // Códigos de Actividad Económica
        public string CodigoSIISucursal { get; set; }  // Código de Sucursal entregado por el SII
        public string Direccion { get; set; }  // Dirección
        public string Comuna { get; set; }  // Comuna 
        public string Ciudad { get; set; }  // Ciudad 
    }
}
