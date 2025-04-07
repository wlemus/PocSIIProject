using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteAPIApplicacion.Models
{
    public class DocumentoNonSQLEntity
    {
        public string Id { get; set; } = null!;
        public string Contenedor { get; set; } = null!;
        public string Particion { get; set; } = null!;
        public string Contenido { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
    }
}
