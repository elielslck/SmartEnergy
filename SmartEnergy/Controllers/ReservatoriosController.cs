using Microsoft.AspNetCore.Mvc;
using SmartEnergy.Models;

namespace SmartEnergy.Controllers
{
    [ApiController]
    [Route("api/")]
    public class ReservatoriosController : ControllerBase
    {
        #region Variables

        private readonly Reservatorios _reservatorios;

        #endregion

        #region Constructor

        public ReservatoriosController()
        {
            _reservatorios = new Reservatorios();
        }

        #endregion

        #region

        [HttpGet("reservatorios")]
        [ProducesResponseType(typeof(Reservatorios), StatusCodes.Status200OK)]
        public ActionResult ListReserv()
        {
            try
            {
                return Ok(_reservatorios.GetAllReserv());
            }
            catch (Exception ex)
            {
                 throw new Exception("Erro ao consultar aplicacao!!" + ex.Message.ToString());
            }
        }
        
        #endregion
    }
}