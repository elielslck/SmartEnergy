using Microsoft.AspNetCore.Mvc;

namespace SmartEnergy.Controllers
{
    [ApiController]
    [Route("api/carga")]
    public class CargaController : ControllerBase
    {

        [HttpGet]
        public string Get(){
            return "ok";
        }
    }
}