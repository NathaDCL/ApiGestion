using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace ApiArchivo.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HomeController : ControllerBase
    {
        [HttpPost("CrearArchivo/{archivo}")]
        public string Post(string archivo)
        {
            String retorno = "";
            if (!Directory.Exists("C:\\Api"))
            {
                Directory.CreateDirectory("C:\\Api");
                retorno = "Directorio creado y";

            }
            
            if (!System.IO.File.Exists($"C:\\Api\\{archivo}.txt"))
            {
                System.IO.File.Create($"C:\\Api\\{archivo}.txt");
                retorno = retorno + " archivo creado";

            }
            else
            {
                retorno = "archivo ya existente";
            }
            return retorno;
            
        }
    }
}
