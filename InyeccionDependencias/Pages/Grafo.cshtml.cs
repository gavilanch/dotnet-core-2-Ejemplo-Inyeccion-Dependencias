using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InyeccionDependencias.Services;

namespace InyeccionDependencias.Pages
{
    public class GrafoModel : PageModel
    {
        public GrafoModel(IServicioA servicioA)
        {
            ServicioA = servicioA;
            MensajeDelServicio = ServicioA.ObtenerMensaje();
        }

        public string MensajeDelServicio { get; private set; }
        public IServicioA ServicioA { get; }

        public void OnGet()
        {
        }
    }
}