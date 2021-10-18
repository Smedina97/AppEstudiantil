using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeguimientoVirtual.App.Persistencia;
using SeguimientoVirtual.App.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SeguimientoVirtual.App.Presentacion.Pages.Estudiantes
{
    public class ConsultasGModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public IEnumerable<Estudiante> estudiante{get; set;}        
        public ConsultasGModel (IRepositorioEstudiante _repoEstudiante){
            this._repoEstudiante=_repoEstudiante;
        }
        public void OnGet()
        {
            estudiante= _repoEstudiante.GetEstudiantesTaller();
        }
    }
}
