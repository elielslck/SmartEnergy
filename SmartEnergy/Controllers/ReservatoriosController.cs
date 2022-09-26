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

        #region Methods

        [HttpGet("reservatorios")]
        [ProducesResponseType(typeof(Reservatorios), StatusCodes.Status200OK)]

        public ActionResult ListReserv(string? reservParam = "")
        {
            try
            {
                var reservList = new List<Reservatorios>();
                if (!string.IsNullOrEmpty(reservParam))
                {
                    reservList = (from Reservatorios item in _reservatorios.GetAllReserv()
                                  where item.Subsistema.ToUpper() == reservParam.ToUpper()
                                  select item).ToList();
                }
                else
                {
                    reservList = _reservatorios.GetAllReserv().ToList();
                }


                return Ok(reservList);



            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar aplicacao!!" + ex.Message);
            }
        }
        #endregion
    }
}