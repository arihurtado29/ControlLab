using ControlLab.Data;
using Microsoft.EntityFrameworkCore;

namespace ControlLab.Control
{
    public class ControlPacientes : IControlPacientes
    {
        private readonly BasedeDatosDbContext _context;

        public ControlPacientes(BasedeDatosDbContext context)
        {
            _context = context;
        }

        public async Task Add(Paciente paciente)
        {
            await _context.Pacientes.AddAsync(paciente); // Cambiar 'Paciente' a 'paciente' para usar el parámetro del método  
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM Pacientes WHERE Id = {0}", id);
        }

        public async Task<Paciente> Get(int id)
        {
            return await _context.Pacientes.FindAsync(id);
        }

        public async Task<List<Paciente>> GetAll()
        {
            return await _context.Pacientes.AsNoTracking().ToListAsync();
        }

        public async Task<bool> SePuedeBorrar(int id)
        {
            var paciente = await _context.Pacientes.Include(_ => _.AnalisisClinicos).SingleAsync(r => r.Id == id);
            return (paciente.AnalisisClinicos!.Count == 0);
        }

        public async Task Update(Paciente paciente)
        {
            _context.Entry(paciente).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
