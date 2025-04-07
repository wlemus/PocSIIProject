using FluentValidation;
using PocSII.DteBusinessRules.Domain;
using PocSII.DteBusinessRules.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteBusinessRules.Validation {
    public class DetailInvoiceValidator : AbstractValidator<DetailDocument> {
        public DetailInvoiceValidator() {
            //Código Item
            RuleFor(x => x.CodigoItem)
            .NotEmpty().WithMessage("Debe existir al menos un código de ítem.")
            .Must(c => c.Count <= 5)
            .WithMessage("No se pueden incluir más de 5 códigos de ítem.")
            .ForEach(item => {
                item.SetValidator(new ItemCodeDetailInvoiceValidator());
            });


            RuleFor(x => x.CantidadItem).NotEqual("0");
            RuleFor(x => x.PrecioItem).NotEqual("0");
            RuleFor(x => x.MontoItem).NotEqual("0");
        }
    }
}