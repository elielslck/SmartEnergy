namespace SmartEnergy.Models
{
    public class Region
    {
        #region Constructor

        public Region()
        {
            this.Geracao = new Geracao();
            this.CargaVerificada = 0;
            this.Importacao = 0;
            this.Exportacao = 0;
        }

        #endregion

        #region Properties

        public Geracao Geracao { get; set; }
        public double CargaVerificada { get; set; }
        public double Importacao { get; set; }
        public double Exportacao { get; set; }

        #endregion
    }
}
