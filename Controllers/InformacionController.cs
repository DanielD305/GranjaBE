using GenesisEfectivo_BE.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Granja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformacionController : ControllerBase
    {
        private readonly ResponseMessage response = new();

        [HttpGet("[action]")]
        public IActionResult GetInformacion()
        {
            try
            {


                List<String> Informacion = new();


                for (int i = 0; i < 8; i++ )
                {
                    Informacion.Add(i.ToString());
                }



                response.Code = "200";
                response.Response = "OK";
                response.data = Informacion;

                return StatusCode(200, response);
            }
            catch (Exception e)
            {
                response.Code = "500";
                response.Response = "Error al obtener  la lista de informacion " + e.Message;

                return StatusCode(500, response);
            }
        }



    }
}
