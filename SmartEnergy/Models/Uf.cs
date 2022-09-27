using RestSharp;

namespace SmartEnergy.Models
{
    public class Uf
    {
        #region Properties
        public int id { get; set; }
        public string sigla { get; set; }
        public string nome { get; set; }
        public ufRegion regiao { get; set; }
        #endregion

        #region Methods
        public List<Uf> GetAllUf()
        {
            return GetUf();
        }

        private List<Uf> GetUf()
        {
            RestClient restClient = new RestClient("https://servicodados.ibge.gov.br/api/v1/localidades/estados?orderBy=nome");
            RestRequest restRequest = new RestRequest("", Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            RestResponse restResponse = restClient.Execute(restRequest);
            return restClient.GetAsync<List<Uf>>(restRequest).GetAwaiter().GetResult();

        }
        #endregion
    }


}