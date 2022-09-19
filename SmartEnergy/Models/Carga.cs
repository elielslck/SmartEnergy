namespace SmartEnergy.Models
{
    public class Carga
    {
           public class Geracao
    {
        public double total { get; set; }
        public double hidraulica { get; set; }
        public double termica { get; set; }
        public double eolica { get; set; }
        public double nuclear { get; set; }
        public double solar { get; set; }
        public double itaipu50HzBrasil { get; set; }
        public double itaipu60Hz { get; set; }
    }

    public class Intercambio
    {
        public double internacional_sul { get; set; }
        public double sul_sudeste { get; set; }
        public double sudeste_nordeste { get; set; }
        public double sudeste_norteFic { get; set; }
        public double norte_norteFic { get; set; }
        public double norteFic_nordeste { get; set; }
    }

    public class Internacional
    {
        public double argentina { get; set; }
        public double paraguai { get; set; }
        public double uruguai { get; set; }
    }

    public class Nordeste
    {
        public Geracao geracao { get; set; }
        public double cargaVerificada { get; set; }
        public double importacao { get; set; }
        public double exportacao { get; set; }
    }

    public class Norte
    {
        public Geracao geracao { get; set; }
        public double cargaVerificada { get; set; }
        public double importacao { get; set; }
        public double exportacao { get; set; }
    }

    public class CargaTotal
    {
        public DateTime Data { get; set; }
        public SudesteECentroOeste sudesteECentroOeste { get; set; }
        public Sul sul { get; set; }
        public Nordeste nordeste { get; set; }
        public Norte norte { get; set; }
        public Internacional internacional { get; set; }
        public Intercambio intercambio { get; set; }
    }

    public class SudesteECentroOeste
    {
        public Geracao geracao { get; set; }
        public double cargaVerificada { get; set; }
        public double importacao { get; set; }
        public double exportacao { get; set; }
    }

    public class Sul
    {
        public Geracao geracao { get; set; }
        public double cargaVerificada { get; set; }
        public double importacao { get; set; }
        public double exportacao { get; set; }
    }


    }
}