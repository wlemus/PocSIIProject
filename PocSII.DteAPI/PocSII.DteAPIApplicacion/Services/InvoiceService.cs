using AutoMapper;
using PocSII.DteAPIApplicacion.DTOs;
using PocSII.DteAPIApplicacion.Enumerables;
using PocSII.DteAPIApplicacion.Services.Interfaces;
using PocSII.DteBusinessRules.Common;
using PocSII.DteBusinessRules.Domain;
using PocSII.DteBusinessRules.Dto;
using PocSII.DteBusinessRules.Enums;
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
        private readonly IDocumentNonSQLService<InvoiceDTO> _invoiceNonSQLService;
        private readonly IProcessDocumentService _processDTEService;
        public InvoiceService(IMapper mapper, ICompanyService companyService, IProcessDocumentService processDTEService, 
            IDocumentNonSQLService<InvoiceDTO> invoiceNonSQLService) {
            _mapper = mapper;
            _processDTEService = processDTEService;
            _companyService = companyService;
            _invoiceNonSQLService = invoiceNonSQLService;
        }

        public async Task<Result<bool>> SendAsync(ElectronicDocument documentoElectronico) {
            //STEP 1: Map the ElectronicDocument to Invoice
            Invoice invoice = _mapper.Map<Invoice>(documentoElectronico);

            //STEP 2: Validate the Invoice
            var resultInvalidInvoice = await invoice.IsInvalid();
            if (resultInvalidInvoice.IsSuccess)
                return Result<bool>.Failure("Errores de validación de datos de entrada",String.Join(",", resultInvalidInvoice.Value));

            //STEP 3: Fill all values invoice TODO
            var invoiceDTO = FillInvoiceDTO(invoice);

            //STEP 4: Send document
          //  _processDTEService = new ProcessDTEService();
            var resultSendTaxService= _processDTEService.SendTaxService(invoiceDTO);


            //STEP 6:Save invoice
            string contenedor = DocumentContainer.Invoice.GetDescription();

            //STEP 7: Notify the user
            SaveDatabase(invoiceDTO);
            return Result<bool>.Success(true);
        }

        private bool SaveDatabase(InvoiceDTO invoiceDTO) {
            string container = DocumentContainer.Invoice.GetDescription();
            string id = invoiceDTO.Factura.Folio;
            string partition = invoiceDTO.Factura.RutEmisor;
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
        public async Task<Result<object>> GetAsync(string folio) {
            string container = DocumentContainer.Invoice.GetDescription();
            var result = await _invoiceNonSQLService.Get(folio, container, "76999999-1"); //TODO: OBTENER DE LOS CLAIMS
            return Result<object>.Success(result);
        }

        public Task<Result<bool>> NotifyAsync(string folio) {
            throw new NotImplementedException();
        }

    }
}
