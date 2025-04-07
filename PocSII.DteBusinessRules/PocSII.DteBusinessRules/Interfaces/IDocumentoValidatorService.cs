using FluentValidation.Results;
using PocSII.DteBusinessRules.Domain;

namespace PocSII.DteBusinessRules.Interfaces
{
    public interface IDocumentoValidatorService {
        Task<ValidationResult> ValidateAsync(DocumentoElectronico documento);

    }
}
