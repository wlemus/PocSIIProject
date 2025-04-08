using PocSII.DteAPIApplicacion.DTOs;
using PocSII.DteAPIApplicacion.Services.Interfaces;
using PocSII.DteAPIApplicacion.Interfaces;
using PocSII.DteBusinessRules.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace PocSII.DteAPIApplicacion.Services
{
   public class InvoiceNonSQLService:IDocumentNonSQLService<InvoiceFullDTO>
    {
        private readonly INonSQLRepository _nonSQLRepository;
        public InvoiceNonSQLService(INonSQLRepository nonSQLRepository) {
            _nonSQLRepository = nonSQLRepository;
        }

        public async Task<InvoiceFullDTO> Get(string itemId, string container, string partition) {
            var result = await _nonSQLRepository.Get(itemId, container, partition);
            if (result == null)
                return null;

            var dto = JsonSerializer.Deserialize<InvoiceFullDTO>(result.Contenido);
            return dto;
        }
     
        public async Task<bool> Insert(string itemId, InvoiceFullDTO item, string container, string partition) {

            string json = JsonSerializer.Serialize(item);
            var result=  await _nonSQLRepository.Insert(itemId, json, container, partition);
            return true;
        }

        public async Task<bool> ExistItemId(string itemId, string container, string partition) {

            return await _nonSQLRepository.ExistItemId(itemId, container, partition);
      
        }

        public async Task<bool> Update(string itemId, InvoiceFullDTO item, string container, string partition) {
            string json = JsonSerializer.Serialize(item);
            var result = await _nonSQLRepository.Update(itemId, json, container, partition);
            return true;
        }
    }
}
