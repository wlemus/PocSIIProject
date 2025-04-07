using PocSII.DteAPIApplicacion.DTOs;
using PocSII.DteAPIApplicacion.Services.Interfaces;
using PocSII.DteAPIApplicacion.Interfaces;
using PocSII.DteBusinessRules.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocSII.DteBusinessRules.Enums;
using PocSII.DteBusinessRules.Common;

namespace PocSII.DteAPIApplicacion.Services
{
    public class CompanyService : ICompanyService {
        private readonly ICompanyRepository _companyRepository;
        private readonly IResolutionRepository _resolutionRepository;
        public CompanyService(ICompanyRepository companyRepository,
            IResolutionRepository resolutionRepository) {
            _companyRepository = companyRepository;
            _resolutionRepository = resolutionRepository;
        }

        public async Task<CompanyDTO> GetCompanyByRut(string rut) {
            var company = await _companyRepository.GetByRut(rut);
            if (company == null)
                return null;

            return new CompanyDTO {
                Rut = company.Rut,
                RazonSocial = company.RazonSocial,
                Giro = company.Giro,
                CorreoElectrónico = company.CorreoElectronico,
                CodigoSIISucursal = company.Sucursales.FirstOrDefault()?.CodigoSiisucursal,
                Telefonos = company.EmpresaTelefonos.Select(t => t.Telefono).ToList(),
                Acteco = company.EmpresaActecos.Select(a => a.Acteco.Codigo).ToList(),
                Direccion = company.Direccion,
                Comuna = company.Comuna,
                Ciudad = company.Ciudad.Nombre,
            };
        }

        public async Task<CompanyFullDTO> GetFullCompanyInformation(string rut) {
            ResolutionDTO resolucion = null;
            FoliosInfoDTO folio = null;
            ElectronicStamp electronicStamp = null;
            var company = await GetCompanyByRut(rut);
            var sucursalId = (new Guid("56E91795-AB7C-480B-B7D8-478F18F6F83B"));

            var resolutionResult = await _resolutionRepository.GetBySucursal(sucursalId, DOCType.Item33.GetXmlEnumValue(), true);
            var resolutionBySucursal = resolutionResult.FirstOrDefault();

            if (resolutionBySucursal != null) {


                var rangoFolios = resolutionBySucursal.RangoFolios.FirstOrDefault();
                resolucion = new ResolutionDTO {
                    Numero = resolutionBySucursal.Numero.ToString(),
                    Fecha = resolutionBySucursal.Fecha.ToDateTime(TimeOnly.MinValue),
                };

                folio = new FoliosInfoDTO {
                    FolioInicial = rangoFolios.FolioDesde.ToString(),
                    FolioFinal = rangoFolios.FolioHasta.ToString(),
                    FechaAutorizacion = rangoFolios.FechaAutorizacion.ToDateTime(TimeOnly.MinValue)
                };
                electronicStamp = new ElectronicStamp {
                    CAF = rangoFolios.CAF,
                    LlavePrivadaCAF = rangoFolios.LlavePrivadaCAF
                };

            }
            return new CompanyFullDTO() {
                Company = company,
                Resolucion = resolucion,
                Folios = folio,
                ElectronicStamp = electronicStamp
            };

        }

        public Task<(ResolutionDTO, FoliosInfoDTO)> GetResolutionBySucursal(Guid sucursalId, string tipoDocumento, bool Vigente) {
            throw new NotImplementedException();
        }
    }
}
