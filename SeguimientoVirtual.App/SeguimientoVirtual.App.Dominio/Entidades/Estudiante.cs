using System;
using System.Collections.Generic;
namespace SeguimientoVirtual.App.Dominio
{
    public class Estudiante : Persona
    {
        public string Direccion {get; set;}
        public double Latitud {get; set;}
        public double Longitud {get; set;}
        public string Ciudad {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public string Grado {get; set;}        
        public List<Materia> Materias{get;set;}
        public Acudiente Acudiente{get; set;}
        public List<Maestro> Maestros{get; set;}        
        public List<Actividad> Actividades{get; set;}
        public List<SugerenciaEstudio> SugerenciasEstudio{get; set;}
    }
}