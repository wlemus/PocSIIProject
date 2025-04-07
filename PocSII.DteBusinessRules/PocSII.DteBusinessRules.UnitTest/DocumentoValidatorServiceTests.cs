using Xunit;
using FluentValidation;
using FluentValidation.Results;
using FluentAssertions;
using Moq;
using PocSII.DteBusinessRules.Validation;
using PocSII.DteBusinessRules.Domain;

namespace PocSII.DteBusinessRules.UnitTest {

    public class DocumentoValidatorServiceTests {

        [Fact]
        public async Task Validate_WithValidDocumento_ReturnsSuccess() {
            var documento = new Invoice {
                RutEmisor = "12345678-9",
                RutReceptor = "98765432-1",
                Folio = "100",
                FechaEmision = "2025-04-04",
                Totales = new TotalsDocument {
                    MontoNeto = "100000",
                    TasaIVA = "19",
                    MontoTotal = "119000"
                },
                Detalle = new List<DetailDocument> {
                    new DetailDocument {
                        CodigoItem = new List<ItemCodeDetailDocument> {
                            new ItemCodeDetailDocument { TipoCodigo = "INT1", ValorCodigo = "123456" }
                        },
                        NombreItem = "Producto 1",
                        DescripcionItem = "Descripción del producto 1",
                        CantidadItem = "2",
                        PrecioItem = "50000",
                        MontoItem = "100000"
                    }
                }
            };           

            var resultado = await documento.IsInvalid();
            Assert.False(resultado.IsSuccess);
        }


        [Fact]
        public async Task ValidateAsync_WithInvalidDocumento_ReturnsFailure() {
            var documento = new Invoice {
                RutEmisor = "12345678",
                RutReceptor = "98765432-1",
                Folio = "100",
                FechaEmision = DateTime.Now.ToString(),
                Totales = new TotalsDocument {
                    MontoNeto = "100000",
                    TasaIVA = "19",
                }
            };

            var resultado = await documento.IsInvalid();

            Assert.True(resultado.IsSuccess);

           //Assert.Contains("",resultado.toa)
           // resultado.Errors.Should().Contain(e => e.PropertyName == "RutEmisor");
           // resultado.Errors.Should().Contain(e => e.PropertyName == "Totales.MontoNeto");
        }

    //    [Fact]
    //    public async Task Validate_WithValidDocumento_ReturnsSuccessMoq() {
    //        // Arrange
    //        var documento = new Factura {
    //            RutEmisor = "12345678-9",
    //            RutReceptor = "98765432-1",
    //            Folio = "100",
    //            FechaEmision = "2025-04-04",
    //            Totales = new DocumentoTotalesDto {
    //                MontoNeto = "100000",
    //                TasaIVA = "19",
    //                MontoTotal = "119000"
    //            }
    //        };

    //        var mockValidator = new Mock<IValidator<DocumentoElectronico>>();
    //        mockValidator
    //         .Setup(v => v.ValidateAsync(documento, It.IsAny<CancellationToken>()))
    //         .ReturnsAsync(new FluentValidation.Results.ValidationResult()); // <-- Sin errores

    //        var service = new DocumentoValidatorService(mockValidator.Object);

    //        // Act
    //        var result = await service.ValidateAsync(documento);

    //        // Assert
    //        result.IsValid.Should().BeTrue();
    //    }

    //    [Fact]
    //    public async Task ValidateAsync_WithInvalidDocumento_ReturnsFailureMoq() {
    ////        var documento = new Factura(); // campos vacíos

    ////        var failures = new List<ValidationFailure>
    ////        {
    ////    new ValidationFailure("RutEmisor", "RutEmisor es requerido"),
    ////    new ValidationFailure("Totales.MontoNeto", "MontoNeto debe ser mayor a 0")
    ////};

    ////        var mockValidator = new Mock<IValidator<DocumentoElectronico>>();
    ////        mockValidator
    ////            .Setup(v => v.ValidateAsync(documento, default))
    ////            .ReturnsAsync(new ValidationResult(failures));

    ////        var service = new DocumentoValidatorService(mockValidator.Object);

    ////        var result = await service.ValidateAsync(documento); 

    ////        result.IsValid.Should().BeFalse();
    ////        result.Errors.Should().Contain(e => e.PropertyName == "RutEmisor");
    ////        result.Errors.Should().Contain(e => e.PropertyName == "Totales.MontoNeto");
    //    }
    }

}