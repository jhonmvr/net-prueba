using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace gestion_pistas_core.Models
{
    public partial class BlogContext : DbContext
    {
        public BlogContext()
        {
        }

        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Persona { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=38.67.136.229;Database=pistas;User ID=NewData;Password=20uhCSTC8N20*");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("PERSONA");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .HasColumnName("APELLIDO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .HasColumnName("CEDULA")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasColumnName("CELULAR")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.HasSequence("seq_actividad_laboral");

            modelBuilder.HasSequence("seq_activo_propiedad");

            modelBuilder.HasSequence("seq_alerta");

            modelBuilder.HasSequence("seq_archivo");

            modelBuilder.HasSequence("seq_asesor_comercial").StartsAt(3);

            modelBuilder.HasSequence("seq_concesionario");

            modelBuilder.HasSequence("seq_concesionario_asesor").StartsAt(3);

            modelBuilder.HasSequence("seq_direccion");

            modelBuilder.HasSequence("seq_estado");

            modelBuilder.HasSequence("seq_ordenamiento");

            modelBuilder.HasSequence("seq_parametro");

            modelBuilder.HasSequence("seq_pista");

            modelBuilder.HasSequence("seq_pista_direccion");

            modelBuilder.HasSequence("seq_pista_relacion_persona");

            modelBuilder.HasSequence("seq_referencia_bancaria");

            modelBuilder.HasSequence("seq_relacion_persona").StartsAt(3);

            modelBuilder.HasSequence("seq_semaforizacion");

            modelBuilder.HasSequence("seq_solicitante");

            modelBuilder.HasSequence("seq_vinculacion_pista");
        }
    }
}
