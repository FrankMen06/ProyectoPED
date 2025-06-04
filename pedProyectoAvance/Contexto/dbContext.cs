using Microsoft.EntityFrameworkCore;
using pedProyectoAvance.modelosBD;

namespace pedProyectoAvance.Contexto;

public class dbContext : DbContext
{
    public dbContext(DbContextOptions<dbContext> options) : base(options)
    {
    }

    public DbSet<Empleados> Empleados { get; set; }
    public DbSet<Estado> Estado { get; set; }
    public DbSet<TipoEmpleado> TipoEmpleados { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleados>()
            .HasOne<Estado>(p => p.Estados)
            .WithMany()
            .HasForeignKey(p => p.Estado)
            .HasPrincipalKey(u => u.EstadoID);
        
        modelBuilder.Entity<Empleados>()
            .HasOne<TipoEmpleado>(p => p.TipoEmpleados)
            .WithMany()
            .HasForeignKey(p => p.TipoEmpleadoID)
            .HasPrincipalKey(u => u.TipoEmpleadoID);
    }
}