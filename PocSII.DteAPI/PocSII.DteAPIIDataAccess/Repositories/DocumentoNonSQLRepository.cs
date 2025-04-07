using Microsoft.EntityFrameworkCore;
using PocSII.DteAPIApplicacion.Interfaces;
using PocSII.DteAPIApplicacion.Models;
using PocSII.DteAPIInfrastructure.Context;


namespace PocSII.DteAPIIDataAccess.Repositories
{
    public class DocumentoNonSQLRepository: INonSQLRepository {
        private readonly PocSIIDbContext _context;
        public DocumentoNonSQLRepository(PocSIIDbContext context) {
            _context = context;
        }
      
        public async Task<DocumentoNonSQLEntity> Get(string itemId, string container, string partition) {
            var company = await _context.DocumentosNonSQL.Where(x => x.Contenedor == container && x.Id==itemId && x.Particion==partition)
                .FirstOrDefaultAsync(x => x.Id == itemId);
            if (company is null)
                return null;

            return company;
        }
        
        public async Task<DocumentoNonSQLEntity> Insert(string itemId, string item, string container, string partition) {
            var entity = new DocumentoNonSQLEntity {
                Id = itemId,
                Contenedor = container,
                Particion = partition,
                Contenido = item,
                FechaCreacion = DateTime.UtcNow
            };

            _context.DocumentosNonSQL.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }


        public async Task<DocumentoNonSQLEntity> Update(string itemId, string item, string container, string partition) {
            var existing = await _context.DocumentosNonSQL
         .Where(x => x.Contenedor == container && x.Particion == partition)
         .FirstOrDefaultAsync(x => x.Id == itemId);

            if (existing == null)
                return null;

            // Actualiza solo los campos necesarios (esto es un ejemplo genérico)
            existing.Contenido = item;         

            _context.DocumentosNonSQL.Update(existing);
            await _context.SaveChangesAsync();

            return existing;
        }
    }
}
