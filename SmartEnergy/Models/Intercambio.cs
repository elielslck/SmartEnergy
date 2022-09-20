namespace SmartEnergy.Models
{
    public class Intercambio
    {
        public Intercambio()
        {
            this.Internacional_sul = 0;
            this.Sul_sudeste = 0;
            this.Sudeste_nordeste = 0;
            this.Sudeste_norteFic = 0;
            this.Norte_norteFic = 0;
            this.NorteFic_nordeste = 0;

        }

        public double Internacional_sul { get; set; }
        public double Sul_sudeste { get; set; }
        public double Sudeste_nordeste { get; set; }
        public double Sudeste_norteFic { get; set; }
        public double Norte_norteFic { get; set; }
        public double NorteFic_nordeste { get; set; }
    }
}
