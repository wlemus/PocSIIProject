using PocSII.DteBusinessRules.Dto;
using PocSII.DteBusinessRules.Enums;
using PocSII.DteProcessor.Common;
using PocSII.DteProcessor.Entities;
using PocSII.DteProcessor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteProcessor.Mapper {
    public static class FacturaDTEMapper {
        public static EnvioDTE MapToEnvioDTE(InvoiceDTO invoiceDto) {

            //-------------------------------Sección 1: SetDTE--------------------
            // Crear la Carátula del SetDTE
            var caratula = new EnvioDTESetDTECaratula {
                version = 1.0m,
                RutEmisor = invoiceDto.Emisor.Rut,
                RutReceptor = invoiceDto.Receptor.Rut,
                RutEnvia = invoiceDto.Emisor.Rut,
                FchResol = invoiceDto.Resolucion.Fecha,
                NroResol = invoiceDto.Resolucion.Numero,
                TmstFirmaEnv = invoiceDto.FechaFirmaDoc,

                // Agregar SubTotDTE
                SubTotDTE = new List<EnvioDTESetDTECaratulaSubTotDTE>{
                new EnvioDTESetDTECaratulaSubTotDTE {
                    NroDTE = "1",
                    TpoDTE = DOCType.Item33
                }}.ToArray()
            };


         
            // Crear el SetDTE
            var setDTE = new EnvioDTESetDTE {
                ID = "SetDoc",
                Caratula = caratula
            };

            //----------------------------------Sección 2: DTE--------------------
            // Crear el Encabezado del Documento
            var encabezadoDocumento = new DTEDefTypeDocumentoEncabezado {
                IdDoc = new DTEDefTypeDocumentoEncabezadoIdDoc {
                    TipoDTE = DTEType.Item33,
                    Folio = invoiceDto.Factura.Folio,
                    FchEmis = Convert.ToDateTime(invoiceDto.Factura.FechaEmision)
                },
                Emisor = new DTEDefTypeDocumentoEncabezadoEmisor {
                    RUTEmisor = invoiceDto.Emisor.Rut,
                    RznSoc = invoiceDto.Emisor.RazonSocial,
                    GiroEmis = invoiceDto.Emisor.Giro,
                    Acteco = invoiceDto.Emisor.Acteco.ToArray(),
                    CdgSIISucur = invoiceDto.Emisor.CodigoSIISucursal,
                    DirOrigen = invoiceDto.Emisor.Direccion,
                    CmnaOrigen = invoiceDto.Emisor.Comuna,
                    CiudadOrigen = invoiceDto.Emisor.Ciudad
                },
                Receptor = new DTEDefTypeDocumentoEncabezadoReceptor {
                    RUTRecep = invoiceDto.Receptor.Rut,
                    RznSocRecep = invoiceDto.Receptor.RazonSocial,
                    GiroRecep = invoiceDto.Receptor.Giro,
                    DirRecep = invoiceDto.Receptor.Direccion,
                    CmnaRecep = invoiceDto.Emisor.Comuna,
                    CiudadRecep = invoiceDto.Emisor.Ciudad
                },
                Totales = new DTEDefTypeDocumentoEncabezadoTotales {
                    MntNeto = invoiceDto.Factura.Totales.MontoNeto,                    
                    TasaIVA = Convert.ToDecimal(invoiceDto.Factura.Totales.TasaIVA),
                    TasaIVASpecified = true,
                    IVA = invoiceDto.Factura.Totales.IVA,
                    MntTotal = invoiceDto.Factura.Totales.MontoTotal
                }
            };

            // Crear el Detalle del Documento
            var detalleDocumento = new List<DTEDefTypeDocumentoDetalle>();
          
            foreach (var (det, index) in invoiceDto.Factura.Detalle.Select((det, index) => (det, index + 1))) {
                detalleDocumento.Add(new DTEDefTypeDocumentoDetalle {
                    NroLinDet = index.ToString(),
                    CdgItem = det.CodigoItem.Select(c => new DTEDefTypeDocumentoDetalleCdgItem {
                        TpoCodigo = c.TipoCodigo,
                        VlrCodigo = c.ValorCodigo
                    }).ToArray(),
                    NmbItem = det.NombreItem,
                    DscItem = det.DescripcionItem,
                    QtyItem = Convert.ToDecimal(det.CantidadItem),
                    QtyItemSpecified=true,
                    PrcItem = Convert.ToDecimal(det.PrecioItem),
                    PrcItemSpecified=true,
                    MontoItem = det.MontoItem,
                });
            }

            // Crear el TED del Documento
            var tedDocumento = new DTEDefTypeDocumentoTED {
                DD = new DTEDefTypeDocumentoTEDDD {
                    RE = invoiceDto.Emisor.Rut,
                    TD = DTEType.Item33,
                    F = invoiceDto.Factura.Folio,
                    FE = Convert.ToDateTime(invoiceDto.Factura.FechaEmision),
                    RR = invoiceDto.Receptor.Rut,
                    RSR = invoiceDto.Receptor.RazonSocial,
                    MNT = Convert.ToDecimal(invoiceDto.Factura.Totales.MontoTotal),
                    IT1 = invoiceDto.Factura.Detalle[0].NombreItem,                    
                    CAF = new DTEDefTypeDocumentoTEDDDCAF {
                        version = "1.0",
                        DA = new DTEDefTypeDocumentoTEDDDCAFDA {
                            RE = invoiceDto.Emisor.Rut,
                            RS = invoiceDto.Emisor.RazonSocial,
                            TD = DTEType.Item33,
                            RNG = new DTEDefTypeDocumentoTEDDDCAFDARNG {
                                D = invoiceDto.FoliosInfo.FolioInicial,
                                H = invoiceDto.FoliosInfo.FolioFinal,                                
                            },
                            FA = invoiceDto.FoliosInfo.FechaAutorizacion,
                            Item = new DTEDefTypeDocumentoTEDDDCAFDARSAPK {
                                M = Convert.FromBase64String("0a4O6Kbx8Qj3K4iWSP4w7KneZYeJ+g/prihYtIEolKt3cykSxl1zO8vSXu397QhTmsX7SBEudTUx++2zDXBhZw=="),
                                E = Convert.FromBase64String("Aw==")
                            },
                            IDK = 100
                        },
                        FRMA = new DTEDefTypeDocumentoTEDDDCAFFRMA {
                            algoritmo = "SHA1withRSA",
                            Value = Convert.FromBase64String("g1AQX0sy8NJugX52k2hTJEZAE9Cuul6pqYBdFxj1N17umW7zG/hAavCALKByHzdYAfZ3LhGTXCai5zNxOo4lDQ==")
                        }
                    },
                    TSTED = invoiceDto.TimbreElectronicoInfo.FechaFirmaDigitalDatoDocumento
                },
                FRMT = new DTEDefTypeDocumentoTEDFRMT {
                    Value = Convert.FromBase64String(invoiceDto.TimbreElectronicoInfo.FirmaElectronicaDocumento)
                }
                };

            // Crear el Documento
            var documento = new DTEDefTypeDocumento {
               ID = invoiceDto.ID, //$"F{invoiceDto.Invoice.Folio}T{DTEType.Item33.GetXmlEnumValue()}",
                Encabezado = encabezadoDocumento,
                Detalle = detalleDocumento.ToArray(),
                TED = tedDocumento,
                TmstFirma = invoiceDto.TimbreElectronicoInfo.FechaFirmaDigitalDatoDocumento
            };

            // Crear el EnvíoDTE
            setDTE.DTE = [new DTEDefType {
                version = 1.0m,
                    Item = documento
                }
            ];

            // Crear el EnvioDTE sin incluir Signature
            var envioDTE = new EnvioDTE {
                version = 1.0m,
                SetDTE = setDTE
            };

            return   envioDTE;

        }
    }
}
