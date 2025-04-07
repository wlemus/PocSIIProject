using FluentValidation;
using PocSII.DteBusinessRules.Common;
using PocSII.DteBusinessRules.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteBusinessRules.Domain
{
   public class Invoice: ElectronicDocument {
       
        public override async Task<Result<List<string>>> IsInvalid() {            
            var _validator = new InvoiceValidator();
            var validatorResult = await _validator.ValidateAsync(this);
            if (validatorResult.IsValid) 
                return Result<List<string>>.Failure("");

             return Result<List<string>>.Success(validatorResult.Errors
            .Select(e => $"{e.PropertyName}: {e.ErrorMessage}")
            .ToList());

        }
    }
}
