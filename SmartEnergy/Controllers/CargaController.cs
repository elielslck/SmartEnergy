using Microsoft.AspNetCore.Mvc;
using SmartEnergy.Models;

namespace SmartEnergy.Controllers
{
    [ApiController]
    [Route("api/")]
    public class CargaController : ControllerBase
    {
        #region Variables

        private readonly Carga _carga;

        #endregion

        #region Constructor

        public CargaController()
        {
            _carga = new Carga();
        }

        #endregion

        [HttpGet("carga")]
        [ProducesResponseType(typeof(Carga), StatusCodes.Status200OK)]
        public ActionResult ListData()
        {
            try
            {
                return Ok(_carga.GetAllCarga());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar aplicacao!!" + ex.Message.ToString());
            }
        }
    }
}