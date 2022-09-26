using Microsoft.AspNetCore.Mvc;
using SmartEnergy.Models;

namespace SmartEnergy.Controllers
{
    [ApiController]
    [Route("api/")]
    public class UfController : ControllerBase
    {
        #region Variables

        private readonly Uf _uf;

        #endregion

        #region Constructor
        public UfController()
        {
            _uf = new Uf();
        }
        #endregion

        #region Methods

        [HttpGet("uf")]
        [ProducesResponseType(typeof(Uf), StatusCodes.Status200OK)]

        public ActionResult ListUf(string? ufParam = "")
        {
            try
            {
                var ufList = new List<Uf>();
                if (!string.IsNullOrEmpty(ufParam))
                {
                    ufList = (from Uf item in _uf.GetAllUf()
                             where item.sigla == ufParam.ToUpper()
                             select item).ToList();
                }
                else
                {
                    ufList = _uf.GetAllUf();
                }

                return Ok(ufList);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar aplicacao!!" + ex.Message);
            }
        }
        #endregion
    }
}
