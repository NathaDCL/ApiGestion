using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
namespace ApiArchivo.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AController : ControllerBase
    {
        [HttpDelete("EliminarArchivo/{archivo}")]
        public string Delete(string archivo)
        {
         String retorno = "";
            if (!Directory.Exists("C:\\Api"))
            {
               
                retorno = "Directorio inexistente";

            }
            else
            {

            
            if (!System.IO.File.Exists($"C:\\Api\\{archivo}.txt"))
            {
                
                retorno = "archivo inexistente";

            }
            else
            {
                    if (System.IO.File.Exists($"C:\\Api\\{archivo}.txt"))
                        {
                        System.IO.File.Delete($"C:\\Api\\{archivo}.txt");
                    }
            }
            
            }
            return retorno;
        }
            
        }
    }
