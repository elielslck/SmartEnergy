using Microsoft.AspNetCore.Mvc;

namespace SmartEnergy.Controllers
{
    [ApiController]
    [Route("api/reservatorios")]
    public class ReservatoriosController : ControllerBase
    {
        [HttpGet]
        public string Get(){
            return "ok";
        }
        
    }
}