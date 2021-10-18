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
    public class ActividadModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        [BindProperty]
        public Estudiante estudiante{get; set;}
        public Actividad actividad{get; set;}
        public ActividadModel(IRepositorioEstudiante _repoEstudiante){
            this._repoEstudiante=_repoEstudiante;
        }
        public ActionResult OnGet(int id)
        {
            estudiante=_repoEstudiante.GetEstudiante(id);
            if(estudiante!=null){
                return Page();
            }
            else{
                return NotFound();
            }
        }

        public IActionResult OnPost(int id, Actividad actividad){
            _repoEstudiante.AdicionarActividad(id, actividad);
            return RedirectToPage ("ConsultarEstudiantes");
        }
    }
}
