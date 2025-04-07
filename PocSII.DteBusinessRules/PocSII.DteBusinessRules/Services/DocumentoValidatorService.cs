using FluentValidation;
using FluentValidation.Results;
using PocSII.DteBusinessRules.Domain;
using PocSII.DteBusinessRules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteBusinessRules.Services
{
    public class DocumentoValidatorService: IDocumentoValidatorService {
        private readonly IValidator<DocumentoElectronico> _validator;
        public DocumentoValidatorService(IValidator<DocumentoElectronico> validator) {
            _validator = validator;
        }
        public async Task<ValidationResult> ValidateAsync(DocumentoElectronico documento) {
            // Implementación de la validación aquí
            var validatorResult= await _validator.ValidateAsync(documento);
            return validatorResult;
        }
    }
    
}
