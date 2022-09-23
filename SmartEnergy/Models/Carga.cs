using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace SmartEnergy.Models
{
  public class Carga
  {
    #region Constructor

    public Carga()
    {
      this.Data = DateTime.Now;
      this.SudesteECentroOeste = new Region();
      this.Sul = new Region();
      this.Nordeste = new Region();
      this.Norte = new Region();
      this.Internacional = new Internacional();
      this.Intercambio = new Intercambio();
    }

    #endregion

    #region Properties

    public DateTime Data { get; set; }
    public Region SudesteECentroOeste { get; set; }
    public Region Sul { get; set; }
    public Region Nordeste { get; set; }
    public Region Norte { get; set; }
    public Internacional Internacional { get; set; }
    public Intercambio Intercambio { get; set; }

    #endregion

    #region Methods

    public Carga GetAllCarga()
    {
      return GetData();
    }

    private Carga GetData()
    {
      //var certificates = new X509CertificateCollection();
      //string certificated = "integra.crt";
      //certificates.Add(integra.crt);
      //var client = new RestClient("https://integra.ons.org.br/api/energiaagora/GetBalancoEnergetico/null");
      var options = new RestClientOptions("https://integra.ons.org.br/api/energiaagora/GetBalancoEnergetico/null")
      {
        //ThrowOnAnyError = true,
        //Timeout = 1000,
        //ClientCertificates = certificates,
        RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => false
      };
      var client = new RestClient(options);
      var request = new RestRequest();
      return client.GetAsync<Carga>(request).Result;
      //return JsonConvert.DeserializeObject<Carga>(response);

    }

    #endregion
  }
}