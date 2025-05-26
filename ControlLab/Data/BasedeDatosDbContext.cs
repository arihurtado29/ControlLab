using Microsoft.EntityFrameworkCore;

namespace ControlLab.Data
{
    public class BasedeDatosDbContext : DbContext
    {
        public BasedeDatosDbContext(
            DbContextOptions<BasedeDatosDbContext> options
            )
            : base(options)
        {
        }
        public DbSet<AnalisisClinico> AnalisisClinicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Quimico> Quimicos { get; set; }
    }
}
