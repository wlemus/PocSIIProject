using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteBusinessRules.Enums
{
  public  enum DTESendStatus
    {
        UploadOk = 0,
    SenderSinPermiso = 1,
    ErrorTamanoArchivo = 2,
    ArchivoCortado = 3,
    NoAutenticado = 5,
    EmpresaNoAutorizada = 6,
    EsquemaInvalido = 7,
    FirmaInvalida = 8,
    SistemaBloqueado = 9,
    ErrorInterno = 99 
    }
}
