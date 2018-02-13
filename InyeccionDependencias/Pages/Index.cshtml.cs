using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InyeccionDependencias.Services;

namespace InyeccionDependencias.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel( )
        {
            //EmailService = emailService;
        }

        //public IEmailService EmailService { get; }

        public string Mensaje { get; set; }

        public void OnGet([FromServices] IEmailService email)
        {
            //Mensaje = EmailService.EnviarCorreo();
            Mensaje = email.EnviarCorreo();
        }
    }
}
