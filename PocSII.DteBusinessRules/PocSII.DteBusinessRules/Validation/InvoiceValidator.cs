using FluentValidation;
using PocSII.DteBusinessRules.Domain;
using PocSII.DteBusinessRules.Enums;

namespace PocSII.DteBusinessRules.Validation
{
    public class InvoiceValidator : AbstractValidator<Invoice> {
        public InvoiceValidator() {
            RuleFor(doc => doc.RutEmisor)
                .NotEmpty().WithMessage("El RUT del emisor es obligatorio.")
                .Matches(@"^\d{7,8}-[0-9kK]$").WithMessage("El RUT del emisor no es válido.");
            RuleFor(doc => doc.RutReceptor)
                .NotEmpty().WithMessage("El RUT del receptor es obligatorio.")
                .Matches(@"^\d{7,8}-[0-9kK]$").WithMessage("El RUT del receptor no es válido.");

            RuleFor(doc => doc.Folio)
                .NotEmpty().WithMessage("El folio es obligatorio.")
                .Matches(@"^\d+$").WithMessage("El folio debe ser un número.");

            RuleFor(doc => doc.FechaEmision)
                .NotEmpty().WithMessage("La fecha de emisión es obligatoria.")
                .Matches(@"^\d{4}-\d{2}-\d{2}$").WithMessage("La fecha de emisión debe estar en formato YYYY-MM-DD.");

            //Payment method
            RuleFor(x => x.FormaPago)
             .Must(value => string.IsNullOrWhiteSpace(value) || Enum.TryParse<InvoicePaymentMethod>(value, true, out _))
             .WithMessage($"El tipo de código debe ser uno de los siguientes: {string.Join(", ", Enum.GetNames<InvoicePaymentMethod>())}");


            //Totals
            RuleFor(doc => doc.Totales)
                .NotNull().WithMessage("Los totales son obligatorios.");

            RuleFor(doc => doc.Totales.MontoNeto)
              .NotEmpty().WithMessage("MontoNeto es obligatorio.").When(doc => doc.Totales != null);

            RuleFor(doc => doc.Totales.TasaIVA)
                .NotEmpty().WithMessage("TasaIVA es obligatoria.").When(doc => doc.Totales != null);

            RuleFor(doc => doc.Totales.MontoTotal)
                .NotEmpty().WithMessage("MontoTotal es obligatorio.").When(doc => doc.Totales != null);


            //Detail
            RuleFor(x => x.Detalle)
             .NotEmpty().WithMessage("Debe existir al menos un detalle.")
             .ForEach(detalle => {
                 detalle.SetValidator(new DetailInvoiceValidator());
             });

        }
    }
    
    
}
