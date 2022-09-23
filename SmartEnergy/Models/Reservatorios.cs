using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Security.Cryptography.X509Certificates;


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
    public Reservatorios GetAllReserv()
    {
      return GetReserv();
    }

    private Reservatorios GetReserv()
    { 
    //var certificates = new X509CertificateCollection();
    //string certificated = "integra.crt";
    //certificates.Add(integra.crt);
    //var client = new RestClient("https://integra.ons.org.br/api/energiaagora/GetBalancoEnergetico/null");
    var options = new RestClientOptions("https://integra.ons.org.br/api/energiaagora/Get/SituacaoDosReservatorios")
    {
      //ThrowOnAnyError = true,
      //Timeout = 1000,
      //ClientCertificates = certificates,
      RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => false
    };
    var client = new RestClient(options);
    var request = new RestRequest();
    return client.GetAsync<Reservatorios>(request).Result;
    //return JsonConvert.DeserializeObject<Carga>(response);

    }

    #endregion
  }

}