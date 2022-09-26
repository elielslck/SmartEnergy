using RestSharp;


namespace SmartEnergy.Models
{
    public class Reservatorios
    {
        #region Constructor

        public Reservatorios()
        {
            this.Data = DateTime.Now;
            this.Subsistema = Subsistema;
            this.Bacia = Bacia;
            this.Reservatorio = Reservatorio;

        }

        #endregion

        #region Parameters
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

        #endregion


        #region Methods
        public List<Reservatorios> GetAllReserv()
        {
            return GetReserv();
        }

        private List<Reservatorios> GetReserv()
        {
            RestClient restClient = new RestClient("https://integra.ons.org.br/api/energiaagora/Get/SituacaoDosReservatorios");
            RestRequest restRequest = new RestRequest("", Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            RestResponse restResponse = restClient.Execute(restRequest);
            return restClient.GetAsync<List<Reservatorios>>(restRequest).GetAwaiter().GetResult();

        }

        #endregion
    }

}