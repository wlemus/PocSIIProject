using FluentValidation;
using PocSII.DteBusinessRules.Domain;
using PocSII.DteBusinessRules.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteBusinessRules.Validation
{
    public class ItemCodeDetailInvoiceValidator : AbstractValidator<ItemCodeDetailDocument> {
        public ItemCodeDetailInvoiceValidator() {
            RuleFor(x => x.TipoCodigo)
                .Must(value => Enum.TryParse<TypeCodeDetailInvoice>(value, true, out _))
                .WithMessage($"El tipo de código debe ser uno de los siguientes: {string.Join(", ", Enum.GetNames<TypeCodeDetailInvoice>())}");

            RuleFor(x => x.ValorCodigo)
                .NotEmpty().WithMessage("El valor del código es obligatorio.");
        }
    }

}
