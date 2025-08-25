using Microsoft.EntityFrameworkCore;
using ExamenCRUD.Models;

namespace ExamenCRUD.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Carrera> Carreras => Set<Carrera>();
        public DbSet<Materia> Materias => Set<Materia>();

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Carrera>(e =>
            {
                e.ToTable("Carrera");
                e.HasKey(x => x.Id);
                e.Property(x => x.Nombre).HasMaxLength(100).IsRequired();
                e.Property(x => x.Cuatrimestres).IsRequired();
            });

            mb.Entity<Materia>(e =>
            {
                e.ToTable("Materia");
                e.HasKey(x => x.Id);
                e.Property(x => x.Nombre).HasMaxLength(150).IsRequired();
                // string, sin enum
                e.Property(x => x.Cuatrimestre).HasMaxLength(20).IsRequired();

                e.HasOne(x => x.Carrera)
                    .WithMany(x => x.Materias)
                    .HasForeignKey(x => x.CarreraId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
