﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace gestion_pistas_core.Models
{
    public partial class pistasContext : DbContext
    {
        public pistasContext()
        {
        }

        public pistasContext(DbContextOptions<pistasContext> options)
            : base(options)
        {
        }
        public virtual DbSet<TbPiParametro> TbPiParametro { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=pistas;User ID=NewData;Password=asd*");
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

            modelBuilder.Entity<TbPiParametro>(entity =>
            {
                entity.ToTable("TB_PI_PARAMETRO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(NEXT VALUE FOR [seq_parametro])");

                entity.Property(e => e.CaracteristicaDos)
                    .HasColumnName("CARACTERISTICA_DOS")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CaracteristicaUno)
                    .HasColumnName("CARACTERISTICA_UNO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Catalogo)
                    .HasColumnName("CATALOGO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.SubCatalogo)
                    .HasColumnName("SUB_CATALOGO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasMaxLength(500)
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
