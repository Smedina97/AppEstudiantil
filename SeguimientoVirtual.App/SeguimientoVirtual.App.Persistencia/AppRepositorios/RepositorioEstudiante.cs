using System;
using System.Collections.Generic;
using System.Linq;
using SeguimientoVirtual.App.Dominio;
using Microsoft.EntityFrameworkCore;


namespace SeguimientoVirtual.App.Persistencia
{
    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        private readonly AppContext _appContext = new AppContext();        

        
        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var EstudianteAdicionado= _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return EstudianteAdicionado.Entity;
        }         
        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var EstudianteEncontrado=_appContext.Estudiantes.Find(estudiante.Id);
            if(EstudianteEncontrado!= null)
            {
                EstudianteEncontrado.Nombre=estudiante.Nombre;
                EstudianteEncontrado.Apellidos=estudiante.Apellidos;
                EstudianteEncontrado.NumeroTelefono=estudiante.NumeroTelefono;
                EstudianteEncontrado.Genero=estudiante.Genero;
                EstudianteEncontrado.Direccion=estudiante.Direccion;
                EstudianteEncontrado.Latitud=estudiante.Latitud;
                EstudianteEncontrado.Longitud=estudiante.Longitud;
                EstudianteEncontrado.Ciudad=estudiante.Ciudad;
                EstudianteEncontrado.FechaNacimiento=estudiante.FechaNacimiento;
                EstudianteEncontrado.Grado=estudiante.Grado;
                
                _appContext.SaveChanges();
            }
            return EstudianteEncontrado;
        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int IdEstudiante){
            return _appContext.Estudiantes.Find(IdEstudiante);
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes(){
            return _appContext.Estudiantes;
        }

        void IRepositorioEstudiante.DeleteEstudiante(int IdEstudiante)
        {
            var EstudianteEncontrado=_appContext.Estudiantes.Find(IdEstudiante);
            if(EstudianteEncontrado!=null){
                _appContext.Estudiantes.Remove(EstudianteEncontrado);
                _appContext.SaveChanges();
            }            
        }

        void IRepositorioEstudiante.AdicionarActividad(int IdEstudiante, Actividad actividad)
        {
            var estudiante=_appContext.Estudiantes.Find(IdEstudiante);
            if(estudiante!=null)
            {
                if(estudiante.Actividades!=null)
                {
                    estudiante.Actividades.Add(actividad);
                }
                else
                {
                    estudiante.Actividades = new List<Actividad>();
                    estudiante.Actividades.Add(actividad);
                }

                var EstudianteEncontrado=_appContext.Estudiantes.Find(estudiante.Id);
                if(EstudianteEncontrado!=null)
                {
                    EstudianteEncontrado.Nombre=estudiante.Nombre;
                    EstudianteEncontrado.Apellidos=estudiante.Apellidos;
                    EstudianteEncontrado.NumeroTelefono=estudiante.NumeroTelefono;
                    EstudianteEncontrado.Genero=estudiante.Genero;
                    EstudianteEncontrado.Direccion=estudiante.Direccion;
                    EstudianteEncontrado.Latitud=estudiante.Latitud;
                    EstudianteEncontrado.Longitud=estudiante.Longitud;
                    EstudianteEncontrado.Ciudad=estudiante.Ciudad;
                    EstudianteEncontrado.FechaNacimiento=estudiante.FechaNacimiento;
                    EstudianteEncontrado.Grado=estudiante.Grado;
                
                    _appContext.SaveChanges();
                }
            }
        }        
        IEnumerable<Estudiante> IRepositorioEstudiante.GetEstudiantesTaller(){
            // return _appContext.Estudiantes.Where(e => e.Actividades.Any(a => a.Nombre=="Taller")).ToList();
            return _appContext.Estudiantes;
        }
        
    }   
}