using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeguimientoVirtual.App.Dominio;
using SeguimientoVirtual.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SeguimientoVirtual.App.Presentacion.Pages.Estudiantes
{
    public class ConsultarEstudiantesModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public IEnumerable<Estudiante> estudiantes{get; set;}
        public ConsultarEstudiantesModel(IRepositorioEstudiante _repoEstudiante){
            this._repoEstudiante=_repoEstudiante;
        }
        public void OnGet()
        {
            estudiantes=_repoEstudiante.GetAllEstudiantes();
        }
    }
}
