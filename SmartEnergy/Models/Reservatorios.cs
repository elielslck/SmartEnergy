namespace SmartEnergy.Models
{
    #region Constructor
    #endregion

    #region Parameters
    public class Reservatorios
    {
        public DateTime Data { get; set; }
        public string Subsistema { get; set; }
        public string Bacia { get; set; }
        public string Reservatorio { get; set; }
        public double ReservatorioMax { get; set; }
        public double ReservatorioEARVerificadaMWMes { get; set; }
        public double ReservatorioEARVerificadaPorcentagem { get; set; }
        public double ReservatorioValorUtil { get; set; }
        public double ReservatorioPorcentagem { get; set; }
        public double BaciaMax { get; set; }
        public double BaciaEARVerificadaMWMes { get; set; }
        public double BaciaEARVerificadaPorcentagem { get; set; }
        public double BaciaPorcentagem { get; set; }
        public double SubsistemaMax { get; set; }
        public double SubsistemaEARVerificadaMWMes { get; set; }
        public double SubsistemaValorUtil { get; set; }
        public double SINMax { get; set; }
        public double SINEARVerificadaMWMes { get; set; }
        public double SINEARPorcentagem { get; set; }
    }
    #endregion
}