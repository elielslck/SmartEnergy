using Microsoft.AspNetCore.Mvc;

namespace SmartEnergy.Controllers
{
    [ApiController]
    [Route("api/")]
    public class ReservatoriosController : ControllerBase
    {
        [HttpGet("reservatorios")]
        public string Get(){
            return "ok";
        }
        
    }
}