using AdministracionUsuario.Entidades;
using Microsoft.EntityFrameworkCore;


namespace AdministracionUsuario
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<cargos> cargos { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
    }
}
