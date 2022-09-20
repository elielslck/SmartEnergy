using Newtonsoft.Json;

namespace SmartEnergy.Models
{
    public class Geracao
    {
        #region Constructor

        public Geracao()
        {

        }

        #endregion

        #region Properties

        public double Total { get; set; }
        public double Hidraulica { get; set; }
        public double Termica { get; set; }
        public double Eolica { get; set; }
        public double Nuclear { get; set; }
        public double Solar { get; set; }

        [JsonIgnore]
        public double? Itaipu50HzBrasil { get; set; }

        [JsonIgnore]
        public double? Itaipu60Hz { get; set; }

        #endregion
    }
}
