using ControlLab.Data;
using Microsoft.EntityFrameworkCore;

namespace ControlLab.Control
{
    public class ControlQuimicos : IControlQuimicos
    {
        private readonly BasedeDatosDbContext _context;
        // Constructor que recibe el contexto de la base de datos
        public ControlQuimicos(BasedeDatosDbContext context)
        {
            _context = context;
        }

        public async Task Add(Quimico quimico)
        {
            await _context.Quimicos.AddAsync(quimico);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM Quimicos WHERE Id = {0}", id);
        }

        public async Task<Quimico> Get(int id)
        {
            return await _context.Quimicos.FindAsync(id);
        }

        public async Task<List<Quimico>> GetAll()
        {
            return await _context.Quimicos.AsNoTracking().ToListAsync();
        }

        public async Task Update(Quimico quimico)
        {
            _context.Entry(quimico).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
