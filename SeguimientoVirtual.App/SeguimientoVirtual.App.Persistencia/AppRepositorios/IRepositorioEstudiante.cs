using System.Collections.Generic;
using SeguimientoVirtual.App.Dominio;

namespace SeguimientoVirtual.App.Persistencia {
    public interface IRepositorioEstudiante {
        IEnumerable<Estudiante> GetAllEstudiantes();
        Estudiante AddEstudiante (Estudiante estudiante);
        Estudiante UpdateEstudiante (Estudiante estudiante);
        void DeleteEstudiante (int IdEstudiante);
        Estudiante GetEstudiante (int IdEstudiante);
        void AdicionarActividad(int IdEstudiante, Actividad actividad);        
        IEnumerable<Estudiante> GetEstudiantesTaller();
    }
}