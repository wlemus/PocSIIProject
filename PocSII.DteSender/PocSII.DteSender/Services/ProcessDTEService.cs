﻿using PocSII.DteBusinessRules.Common;
using PocSII.DteBusinessRules.Domain;
using PocSII.DteBusinessRules.Dto;
using PocSII.DteBusinessRules.Enums;
using PocSII.DteBusinessRules.Exceptions;
using PocSII.DteBusinessRules.Interfaces;
using PocSII.DteProcessor.Common;
using PocSII.DteProcessor.Mapper;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace PocSII.DteProcessor.Services
{
   
    public class ProcessDTEService : IProcessDocumentService {

        private readonly DteSenderService _dteSender;
        private readonly DteQueryService _dteQueryService;
        public ProcessDTEService(DteSenderService dteSender, DteQueryService dteQueryService) {
            _dteSender = dteSender;
            _dteQueryService = dteQueryService;
        }
       
        public async Task<Result<DTEResultSendDTO>> SendTaxService(InvoiceDTO invoice) {

            DTEResultSendDTO respEnvio =null;
            Result<DTEResponseReception> sendDteXmlAsyncResult = null;
            string xmlSerialized = string.Empty;
            try {
                //PASO 1: Sellar documento
                invoice.TimbreElectronicoInfo.FechaFirmaDigitalDatoDocumento = DateTime.Now;
               invoice.TimbreElectronicoInfo.FirmaElectronicaDocumento= ElectronicStampService.SignDDNode(invoice);

                //PASO 2: Mapear el DTO a la entidad DTE
                var envioDTE =  FacturaDTEMapper.MapToEnvioDTE(invoice);                                        
                // Fecha de la firma
                envioDTE.SetDTE.Caratula.TmstFirmaEnv = DateTime.Now;

                //PASO 3: Serializar el DTE a XML
                xmlSerialized = XmlHelper.SerializeToXml(envioDTE);


                //PASO 4:  Firmar el archivo TODO
                // string Certificate = "C:/Users/W/source/repos/PocSIIProject/PocSII.DteSender/PocSII.DteSender/Resouces/certificate.pem";

                byte[] certificateBytes = Utils.GetEmbeddedResourceBytes("certificate.pem");
                RSACryptoServiceProvider Key = new RSACryptoServiceProvider();

                string signedXml = ElectronicStampService.SignXmlFile(xmlSerialized, Key, certificateBytes);

                //PASO 5: Validar el XML con el esquema XSD
                var validateXmlResult = XmlValidator.ValidateXml(xmlSerialized);

           if (!validateXmlResult.IsSuccess)              
                return   Result<DTEResultSendDTO>.Failure(validateXmlResult.Error);

            //PASO 5: Enviar el XML al servicio web
             sendDteXmlAsyncResult = await _dteSender.SendDteXmlAsync(invoice.Factura.Folio,  Environment.GetEnvironmentVariable("SII_ENDPOINT_ENVIO"));

            } catch (Exception ex) {

                Result<DTEResultSendDTO>.Failure($"Error al enviar el DTE: {ex.Message}");
            }
            //PASO 6: Procesar la respuesta del servicio web
          

            if (!sendDteXmlAsyncResult.IsSuccess)
                return Result<DTEResultSendDTO>.Failure($"{sendDteXmlAsyncResult.Error}");

            switch (sendDteXmlAsyncResult.Value.Status) {
                    case 0: {
                            // El envío fue exitoso
                            // Se procesar la respuesta y devuelve el resultado
                            // Por ejemplo, puedes guardar el TrackID y la fecha de recepción en tu base de datos
                            respEnvio = new DTEResultSendDTO {
                                TrackID = sendDteXmlAsyncResult.Value.TrackId,
                                XMLSent = xmlSerialized,
                                ReceptionDate = Convert.ToDateTime(DateTime.Now)
                            };
                        } break;
                        case 1:
                            throw new DTESentException(DTESendStatus.SenderSinPermiso, sendDteXmlAsyncResult.Value);
                        case 2:
                            throw new DTESentException(DTESendStatus.ErrorTamanoArchivo, sendDteXmlAsyncResult.Value);
                        case 3:
                            throw new DTESentException(DTESendStatus.ArchivoCortado, sendDteXmlAsyncResult.Value);
                        case 5:
                            throw new DTESentException(DTESendStatus.NoAutenticado, sendDteXmlAsyncResult.Value);
                        case 6:
                            throw new DTESentException(DTESendStatus.EmpresaNoAutorizada, sendDteXmlAsyncResult.Value);
                        case 7:
                            throw new DTESentException(DTESendStatus.EsquemaInvalido, sendDteXmlAsyncResult.Value);
                        case 8:
                            throw new DTESentException(DTESendStatus.FirmaInvalida, sendDteXmlAsyncResult.Value);
                        case 9:
                            throw new DTESentException(DTESendStatus.SistemaBloqueado, sendDteXmlAsyncResult.Value);
                        default:                          
                            throw new DTESentException(DTESendStatus.ErrorInterno, sendDteXmlAsyncResult.Value);                                                 
                    }
                                   

            return Result<DTEResultSendDTO>.Success(respEnvio);
        }

        public async Task<Result<DTEResponseQuery>> GetTaxService(InvoiceDTO invoice) {      
            Result<DTEResponseQuery> getDteXmlAsyncResult = null;
            try { 
                getDteXmlAsyncResult = await _dteQueryService.GetDteAsync($"{invoice.Factura.Folio}00", Environment.GetEnvironmentVariable("SII_ENDPOINT_CONSULTA"));
                           

            if (!getDteXmlAsyncResult.IsSuccess)
                return Result<DTEResponseQuery>.Failure($"{getDteXmlAsyncResult.Error}");
            
            } catch (Exception ex) {
                Result<DTEResponseQuery>.Failure($"Error al enviar el DTE: {ex.Message}");
            }

            return Result<DTEResponseQuery>.Success(getDteXmlAsyncResult.Value);
        }
        public Task<Result<bool>> NotifySubmission(InvoiceDTO factura) {
            throw new NotImplementedException();
        }

       
    }


}
