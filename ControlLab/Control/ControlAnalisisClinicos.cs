using ControlLab.Data;
using Microsoft.EntityFrameworkCore;

namespace ControlLab.Control
{
    public class ControlAnalisisClinicos : IControlAnalisisClinicos
    {
        private readonly BasedeDatosDbContext _context;

        public ControlAnalisisClinicos(BasedeDatosDbContext context)
        {
            _context = context;
        }

        public async Task Add(AnalisisClinico analisisClinico)
        {
            await _context.AnalisisClinicos.AddAsync(analisisClinico);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM AnalisisClinicos WHERE Id = {0}", id);
        }

        public async Task<AnalisisClinico> Get(int id)
        {
            return await _context.AnalisisClinicos.FindAsync(id);
        }

        public async Task<List<AnalisisClinico>> GetAll()
        {
            return await _context.AnalisisClinicos.Include(p=>p.Paciente).Include(q => q.Quimico).AsNoTracking().ToListAsync();
            //Modiificar esto puede ser que este sea el error
        }

        public async Task Update(AnalisisClinico analisisClinico)
        {
            _context.Entry(analisisClinico).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            
        }
    }
}
