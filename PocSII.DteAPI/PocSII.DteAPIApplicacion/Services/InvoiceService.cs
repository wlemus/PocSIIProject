using AutoMapper;
using Microsoft.Extensions.Logging;
using PocSII.DteAPIApplicacion.DTOs;
using PocSII.DteAPIApplicacion.Enumerables;
using PocSII.DteAPIApplicacion.Services.Interfaces;
using PocSII.DteBusinessRules.Common;
using PocSII.DteBusinessRules.Domain;
using PocSII.DteBusinessRules.Dto;
using PocSII.DteBusinessRules.Enums;
using PocSII.DteBusinessRules.Exceptions;
using PocSII.DteBusinessRules.Interfaces;
using PocSII.DteProcessor.Services;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteAPIApplicacion.Services
{
    public class InvoiceService : IDocumentService {
        private readonly IMapper _mapper;
        private readonly ICompanyService _companyService;
        private readonly ILogger<InvoiceService> _logger;
        private readonly IDocumentNonSQLService<InvoiceFullDTO> _invoiceNonSQLService;
        private readonly IProcessDocumentService _processDTEService;
        public InvoiceService(IMapper mapper, ICompanyService companyService, IProcessDocumentService processDTEService, 
            IDocumentNonSQLService<InvoiceFullDTO> invoiceNonSQLService, ILogger<InvoiceService> logger) {
            _mapper = mapper;
            _processDTEService = processDTEService;
            _companyService = companyService;
            _invoiceNonSQLService = invoiceNonSQLService;
            _logger = logger;
        }

        public async Task<Result<object>> GetAsync(string folio) {
            string container = DocumentContainer.Invoice.GetDescription();
            var result = await _invoiceNonSQLService.Get(folio, container, "76999999-1"); //TODO: OBTENER DE LOS CLAIMS
            return Result<object>.Success(result);
        }
        public async Task<Result<object>> GetStatusAsync(string folio) {
            try {

                var resultGetTaxService = await _processDTEService.GetTaxService( new InvoiceDTO { Factura = new Invoice { Folio = folio } });

                if (!resultGetTaxService.IsSuccess)
                    return Result<object>.Failure("Error en el envio del documento", resultGetTaxService.Error);
              

                return Result<object>.Success(resultGetTaxService.Value);

            } catch (Exception) {

                throw;
            }
        }
        public async Task<Result<string>> SendAsync(ElectronicDocument documentoElectronico) {
           
            //STEP 1: Map the ElectronicDocument to Invoice
            Invoice invoice = _mapper.Map<Invoice>(documentoElectronico);

            //STEP 2: Validate the Invoice
            var resultInvalidInvoice = await invoice.IsInvalid();
            if (resultInvalidInvoice.IsSuccess)
                return Result<string>.Failure("Errores de validación de datos de entrada", String.Join(",", resultInvalidInvoice.Value));

            //STEP 3: Fill all values invoice TODO
            var invoiceDTO = FillInvoiceDTO(invoice);
            try {


                //STEP 4: Send document
                //  _processDTEService = new ProcessDTEService();
                var resultSendTaxService = await _processDTEService.SendTaxService(invoiceDTO);

                if (!resultSendTaxService.IsSuccess)
                    return Result<string>.Failure("Error en el envio del documento", resultSendTaxService.Error);
                //STEP 6:Save invoice
                string contenedor = DocumentContainer.Invoice.GetDescription();
                var invoiceFullDTO = new InvoiceFullDTO { DTE = invoiceDTO, respuestaSII = resultSendTaxService.Value };
                //STEP 7: Notify the user
                SaveDatabase(invoiceFullDTO);

                return Result<string>.Success($"DTE enviado y registrado con éxito, trackId:{resultSendTaxService.Value.TrackID.ToString()}");

            } catch (DTESentException ex) {
                string msjError;
                //TODO: Aqui se debe tener un comportamiento diferente según el tipo de error
                _logger.LogError($"Error al enviar DTE: {ex.EstadoEnvio} - {ex.RespuestaEnvio}");
                switch (ex.EstadoEnvio) {
                    case DTESendStatus.SenderSinPermiso:
                        // Recomendación: Verificar que el certificado digital tenga los permisos adecuados
                        msjError = "El emisor no tiene permiso para enviar el DTE.";
                        break;
                    case DTESendStatus.ErrorTamanoArchivo:
                        // Recomendación: Validar el tamaño del XML antes de enviarlo (no debe superar el límite del SII)
                        msjError = "El archivo excede el tamaño permitido por el SII.";
                        break;
                    case DTESendStatus.ArchivoCortado:
                        // Recomendación: Asegurarse de que el archivo XML se esté generando y enviando completo
                        msjError = "El archivo fue recibido incompleto o cortado.";
                        break;
                    case DTESendStatus.NoAutenticado:
                        // Recomendación: Validar autenticación con el SII (token válido y vigente)
                        msjError = "No autenticado correctamente ante el SII.";
                        break;
                    case DTESendStatus.EmpresaNoAutorizada:
                        // Recomendación: Verificar que la empresa esté autorizada en el sistema del SII para emitir DTE
                        msjError = "La empresa no está autorizada para emitir DTE en el SII.";
                        break;
                    case DTESendStatus.EsquemaInvalido:
                        // Recomendación: Validar el XML contra el esquema XSD oficial del SII antes del envío
                        msjError = "El archivo XML no cumple con el esquema del SII.";
                        break;
                    case DTESendStatus.FirmaInvalida:
                        // Recomendación: Verificar que el DTE esté firmado correctamente con el certificado digital correspondiente
                        msjError = "La firma del documento es inválida.";
                        break;
                    case DTESendStatus.SistemaBloqueado:
                        // Recomendación: Implementar reintentos con backoff y monitoreo del estado del servicio del SII
                        msjError = "El sistema del SII está temporalmente bloqueado. Intente nuevamente más tarde.";
                        break;
                    case DTESendStatus.ErrorInterno:
                    default:
                        // Recomendación: Registrar para análisis posterior, retornar mensaje genérico
                        msjError = "Error interno inesperado al enviar DTE.";

                        return Result<string>.Failure("Error en el envio del documento", ex.Message);
                }
            }

             

            return Result<string>.Success("OK");
        }

        private bool SaveDatabase(InvoiceFullDTO invoiceDTO) {
            string container = DocumentContainer.Invoice.GetDescription();
            string id = invoiceDTO.DTE.Factura.Folio;
            string partition = invoiceDTO.DTE.Factura.RutEmisor;
            var result = _invoiceNonSQLService.Insert(id, invoiceDTO, container, partition);
            return result.Result;
        }
        private InvoiceDTO FillInvoiceDTO(Invoice invoice) {

            CompanyFullDTO senderCompanyFullDTO = _companyService.GetFullCompanyInformation(invoice.RutEmisor).Result;
            var recieverCompany = _companyService.GetCompanyByRut(invoice.RutReceptor).Result;

            return new InvoiceDTO {
                ID = $"F{invoice.Folio}T{DOCType.Item33.GetXmlEnumValue()}",
                Factura = invoice,
                Emisor = senderCompanyFullDTO.Company,
                FoliosInfo = senderCompanyFullDTO.Folios,
                Resolucion = senderCompanyFullDTO.Resolucion,
                TimbreElectronicoInfo = senderCompanyFullDTO.ElectronicStamp,
                FechaFirmaDoc = DateTime.Now,
                Receptor = recieverCompany
            };
        }
       

        public Task<Result<bool>> NotifyAsync(string folio) {
            throw new NotImplementedException();
        }

    }
}
