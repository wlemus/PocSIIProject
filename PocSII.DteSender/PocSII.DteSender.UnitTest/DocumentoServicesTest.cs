using FluentValidation;
using Moq;
using PocSII.DteBusinessRules.Domain;
using PocSII.DteBusinessRules.Dto;
using PocSII.DteProcessor.Services;
namespace PocSII.DteProcessor.UnitTest {
    public class DocumentoServicesTest {
        [Fact]
        public async Task SendTaxSerice_WithValidFactura_ReturnsSuccess() {
            // Arrange
            var factura = new InvoiceDTO {
                ID = "F60T33",
                Factura = new Invoice {
                    Folio = "60",
                    Totales = new TotalsDocument {
                        MontoNeto = "100000",
                        IVA = "19",
                        TasaIVA = "19",
                        MontoTotal = "119000"
                    },
                    FechaEmision = DateTime.Now.ToString(),
                    FormaPago = "1",
                    RutEmisor = "97975000-5",
                    RutReceptor = "77777777-7",
                    Detalle = new List<DetailDocument>{
                    new DetailDocument {
                        NombreItem = "Parlantes Multimedia 180W",
                        CantidadItem = "20",
                        PrecioItem = "4500",
                        MontoItem = "90000",
                        CodigoItem = new List<ItemCodeDetailDocument>
                        {
                            new ItemCodeDetailDocument
                            {
                                TipoCodigo = "INT1",
                                ValorCodigo = "001"
                            }
                        }
                    },
                      new DetailDocument {
                        NombreItem = "Caja de Diskettes 10 Unidades",
                        CantidadItem = "5",
                        PrecioItem = "1000",
                        MontoItem = "5000",
                        CodigoItem = new List<ItemCodeDetailDocument>
                        {
                            new ItemCodeDetailDocument
                            {
                                TipoCodigo = "INT1",
                                ValorCodigo = "1515"
                            }
                        }
                    }
                }
                },
                Emisor = new CompanyDTO {
                    Rut = "97975000-5",
                    RazonSocial = "RUT DE PRUEBA",
                    Giro = "Insumos de Computacion",
                    Acteco = new List<string> { "31341" },
                    CodigoSIISucursal = "1234",
                    Direccion = "Teatinos 120, Piso 4",
                    Comuna = "Santiago",
                    Ciudad = "Santiago"
                },
                Receptor = new CompanyDTO {
                    Rut = "77777777-7",
                    RazonSocial = "EMPRESA LTDA",
                    Giro = "COMPUTACION",
                    Direccion = "SAN DIEGO 2222",
                    Comuna = "LA FLORIDA",
                    Ciudad = "SANTIAGO"
                },
                Resolucion = new ResolutionDTO {
                    Numero = "0",
                    Fecha = DateTime.Parse("2003-09-02")
                },
                FoliosInfo = new FoliosInfoDTO {
                    FolioInicial = "1",
                    FolioFinal = "200",
                    FechaAutorizacion = DateTime.Parse("2003-09-04")
                },
                FechaFirmaDoc = DateTime.Parse("2003-09-04"),
                TimbreElectronicoInfo = new ElectronicStamp {
                     CAF= "<CAF version=\"1.0\"><DA><RE>97975000-5</RE><RS>RUT DE PRUEBA</RS><TD>33</TD><RNG><D>1</D><H>200</H></RNG><FA>2003-09-04</FA></DA><RSAPK><M>0a4O6Kbx8Qj3K4iWSP4w7KneZYeJ+g/prihYtIEolKt3cykSxl1zO8vSXu397QhTmsX7SBEudTUx++2zDXBhZw==</M><E>Aw==</E></RSAPK></CAF>",
                    FechaFirmaDigitalDatoDocumento = DateTime.Parse("2003-10-13"),                  
                    FirmaElectronicaDocumento = "GbmDcS9e/jVC2LsLIe1iRV12Bf6lxsILtbQiCkh6mbjckFCJ7fj/kakFTS06Jo8i\r\nS4HXvJj3oYZuey53Krniew=="
                },
            };

            Environment.SetEnvironmentVariable("SII_ENDPOINT_ENVIO", "https://localhost/sii/dte/envio");

            var _dteSender = new DteSenderService( new HttpClient());

            var service = new ProcessDTEService(_dteSender); // Asumiendo constructor sin dependencias

            // Act
            var result = await service.SendTaxService(factura);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Value.TrackID);
        }


        [Fact]
        public async Task SendTaxSerice_WithValidFactura_ReturnsInvalidXSD() {
            // Arrange
            var factura = new InvoiceDTO {
                Factura = new Invoice {
                    Folio = "60",
                    Totales = new TotalsDocument {
                        MontoNeto = "100000",
                        IVA = "19",
                        TasaIVA = "19",
                        MontoTotal = "119000"
                    },
                    FechaEmision = DateTime.Now.ToString(),
                    FormaPago = "1",
                    RutEmisor = "97975000-5",
                    RutReceptor = "77777777-7",
                    Detalle = new List<DetailDocument>{
                    new DetailDocument {
                        NombreItem = "Parlantes Multimedia 180W",
                        CantidadItem = "20",
                        PrecioItem = "4500",
                        MontoItem = "90000",
                        CodigoItem = new List<ItemCodeDetailDocument>
                        {
                            new ItemCodeDetailDocument
                            {
                                TipoCodigo = "INT1",
                                ValorCodigo = "001"
                            }
                        }
                    },
                      new DetailDocument {
                        NombreItem = "Caja de Diskettes 10 Unidades",
                        CantidadItem = "5",
                        PrecioItem = "1000",
                        MontoItem = "5000",
                        CodigoItem = new List<ItemCodeDetailDocument>
                        {
                            new ItemCodeDetailDocument
                            {
                                TipoCodigo = "INT1",
                                ValorCodigo = "1515"
                            }
                        }
                    }
                }
                },
                Emisor = new CompanyDTO {
                    Rut = "97975000-5",
                    RazonSocial = "RUT DE PRUEBA",
                    Giro = "Insumos de Computacion",
                    Acteco = new List<string> { "31341" },
                    CodigoSIISucursal = "1234",
                    Direccion = "Teatinos 120, Piso 4",
                    Comuna = "Santiago",
                    Ciudad = "Santiago"
                },
                Receptor = new CompanyDTO {
                    Rut = "77777777-7",
                    RazonSocial = "EMPRESA LTDA",
                    Giro = "COMPUTACION",
                    Direccion = "SAN DIEGO 2222",
                    Comuna = "LA FLORIDA",
                    Ciudad = "SANTIAGO"
                },
                Resolucion = new ResolutionDTO {
                    Numero = "0",
                    Fecha = DateTime.Parse("2003-09-02")
                },
                FoliosInfo = new FoliosInfoDTO {
                    FolioInicial = "1",
                    FolioFinal = "200",
                    FechaAutorizacion = DateTime.Parse("2003-09-04")
                },
                FechaFirmaDoc = DateTime.Parse("2003-09-04"),
                TimbreElectronicoInfo = new ElectronicStamp {
                    CAF= "<CAF version=\"1.0\"><DA><RE>97975000-5</RE><RS>RUT DE PRUEBA</RS><TD>33</TD><RNG><D>1</D><H>200</H></RNG><FA>2003-09-04</FA></DA><RSAPK><M>0a4O6Kbx8Qj3K4iWSP4w7KneZYeJ+g/prihYtIEolKt3cykSxl1zO8vSXu397QhTmsX7SBEudTUx++2zDXBhZw==</M><E>Aw==</E></RSAPK></CAF>",
                    FechaFirmaDigitalDatoDocumento = DateTime.Parse("2003-10-13"),
                    FirmaElectronicaDocumento = "GbmDcS9e/jVC2LsLIe1iRV12Bf6lxsILtbQiCkh6mbjckFCJ7fj/kakFTS06Jo8i\r\nS4HXvJj3oYZuey53Krniew=="
                },
            };

            Environment.SetEnvironmentVariable("SII_ENDPOINT_ENVIO", "https://localhost/sii/dte/envio");

            var _dteSender = new DteSenderService(new HttpClient());

            var service = new ProcessDTEService(_dteSender); // Asumiendo constructor sin dependencias

            // Act
            var result = await service.SendTaxService(factura);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Contains(result.Error, "La validación del XSD ha fallado");
        }
    }
}