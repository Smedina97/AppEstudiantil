using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeguimientoVirtual.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguimientoVirtual.App.Dominio;

namespace AppEstudiantil.App.Presentacion.Pages.Estudiantes
{
    public class CrearEstudiantesModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public Estudiante estudiante{get; set;}        
        public CrearEstudiantesModel(IRepositorioEstudiante _repoEstudiante){
            this._repoEstudiante=_repoEstudiante;
        }
        public void OnGet()
        {
            estudiante = new Estudiante();
        }
        public void OnPost(Estudiante estudiante){
            _repoEstudiante.AddEstudiante(estudiante);
        }
    }
}
