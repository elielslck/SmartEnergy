using Microsoft.AspNetCore.Mvc;

namespace SmartEnergy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservatoriosController : ControllerBase
    {
        [HttpGet]
        public string Get(){
            return "ok";
        }
        
    }
}