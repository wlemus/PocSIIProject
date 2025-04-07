using PocSII.DteBusinessRules.Domain;
using PocSII.DteBusinessRules.Enums;
using System.Dynamic;


namespace PocSII.DteBusinessRules.Exceptions
{
    public class DTESentException: Exception
    {
        public DTESendStatus EstadoEnvio { get; }
        public DTEResponseReception RespuestaEnvio { get; }

        public DTESentException( DTESendStatus estadoEnvio, DTEResponseReception respuestaEnvio = null) 
            : base (GetMessageForStatus(estadoEnvio)) {
            RespuestaEnvio = respuestaEnvio;
        }

        private static string GetMessageForStatus(DTESendStatus sendStatus) {
            return sendStatus switch {
                DTESendStatus.UploadOk => "Upload OK.",
                DTESendStatus.SenderSinPermiso => "El Sender no tiene permiso para enviar.",
                DTESendStatus.ErrorTamanoArchivo => "Error en tamaño del archivo (muy grande o muy chico).",
                DTESendStatus.ArchivoCortado => "Archivo cortado (tamaño distinto al parámetro size).",
                DTESendStatus.NoAutenticado => "No está autenticado.",
                DTESendStatus.EmpresaNoAutorizada => "Empresa no autorizada a enviar archivos.",
                DTESendStatus.EsquemaInvalido => "Esquema inválido.",
                DTESendStatus.FirmaInvalida => "Firma del documento inválida.",
                DTESendStatus.SistemaBloqueado => "Sistema bloqueado.",
                DTESendStatus.ErrorInterno => "Error interno.",
                _ => "Error desconocido."
            };
        }
    }
}
