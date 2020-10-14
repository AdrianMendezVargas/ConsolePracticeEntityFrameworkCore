using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsolePracticeEntityFrameworkCore.Models
{
    public partial class PracticaCRUDContext : DbContext
    {
        public PracticaCRUDContext()
        {
        }

        public PracticaCRUDContext(DbContextOptions<PracticaCRUDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Personas> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server= (localdb)\\mssqllocaldb; Database=PracticaCRUD; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personas>(entity =>
            {
                entity.ToTable("personas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
