﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeguimientoVirtual.App.Persistencia;

namespace SeguimientoVirtual.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.Actividad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId");

                    b.ToTable("Actividades");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.SugerenciaEstudio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<string>("Progreso")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId");

                    b.ToTable("SugerenciasEstudio");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.Acudiente", b =>
                {
                    b.HasBaseType("SeguimientoVirtual.App.Dominio.Persona");

                    b.Property<string>("Parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Acudiente");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("SeguimientoVirtual.App.Dominio.Persona");

                    b.Property<int?>("AcudienteId")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Grado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitud")
                        .HasColumnType("float");

                    b.Property<double>("Longitud")
                        .HasColumnType("float");

                    b.HasIndex("AcudienteId");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.Maestro", b =>
                {
                    b.HasBaseType("SeguimientoVirtual.App.Dominio.Persona");

                    b.Property<string>("Asignatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.HasIndex("EstudianteId");

                    b.HasDiscriminator().HasValue("Maestro");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.Tutor", b =>
                {
                    b.HasBaseType("SeguimientoVirtual.App.Dominio.Persona");

                    b.Property<string>("Asignatura")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tutor_Asignatura");

                    b.Property<DateTime>("Disponibilidad")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Tutor");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.Actividad", b =>
                {
                    b.HasOne("SeguimientoVirtual.App.Dominio.Estudiante", null)
                        .WithMany("Actividades")
                        .HasForeignKey("EstudianteId");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.Materia", b =>
                {
                    b.HasOne("SeguimientoVirtual.App.Dominio.Estudiante", null)
                        .WithMany("Materias")
                        .HasForeignKey("EstudianteId");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.SugerenciaEstudio", b =>
                {
                    b.HasOne("SeguimientoVirtual.App.Dominio.Estudiante", null)
                        .WithMany("SugerenciasEstudio")
                        .HasForeignKey("EstudianteId");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.Estudiante", b =>
                {
                    b.HasOne("SeguimientoVirtual.App.Dominio.Acudiente", "Acudiente")
                        .WithMany()
                        .HasForeignKey("AcudienteId");

                    b.Navigation("Acudiente");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.Maestro", b =>
                {
                    b.HasOne("SeguimientoVirtual.App.Dominio.Estudiante", null)
                        .WithMany("Maestros")
                        .HasForeignKey("EstudianteId");
                });

            modelBuilder.Entity("SeguimientoVirtual.App.Dominio.Estudiante", b =>
                {
                    b.Navigation("Actividades");

                    b.Navigation("Maestros");

                    b.Navigation("Materias");

                    b.Navigation("SugerenciasEstudio");
                });
#pragma warning restore 612, 618
        }
    }
}
