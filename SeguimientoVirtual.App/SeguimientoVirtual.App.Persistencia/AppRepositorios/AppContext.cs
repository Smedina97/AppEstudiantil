using Microsoft.EntityFrameworkCore;
using SeguimientoVirtual.App.Dominio;

namespace SeguimientoVirtual.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas{get; set;}
        public DbSet<Estudiante> Estudiantes {get; set;}
        public DbSet<Maestro> Maestros {get; set;}
        public DbSet<Acudiente> Acudientes {get; set;}
        public DbSet<Tutor> Tutores {get; set;} 
        public DbSet<Actividad> Actividades{get; set;}
        public DbSet<Materia> Materias{get; set;}
        public DbSet<SugerenciaEstudio> SugerenciasEstudio{get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer
            ("Server=tcp:databaseappestudiantilmindtech.database.windows.net,1433;Initial Catalog=AppEstudiantil;Persist Security Info=False;User ID=smedina;Password=Sebacho1997!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    } 


    }
}