using AracSimulasyonuApp.Core;
using AracSimulasyonuApp.Enum;
using AracSimulasyonuApp.Interfaces;

namespace AracSimulasyonuApp
{
    public partial class Form1 : Form
    {
        private List<IArac> araclar;
        private List<KiralamaBilgisi> kiralananAraclar = new List<KiralamaBilgisi>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            araclar = new List<IArac>
            {
            new Araba("BMW 320i", AracTipi.Sedan, 1500m),
            new Araba("Jeep Wrangler", AracTipi.SUV, 2000m),
            new Araba("Ford Focus", AracTipi.Hatchback, 1000m),
            new Araba("Mercedes C Coupe", AracTipi.Coupe, 1800m),
            new Araba("Mazda MX-5", AracTipi.Cabriolet, 2200m),
            new Araba("Ford F-150", AracTipi.Pickup, 2500m),
            new Araba("Volkswagen Sharan", AracTipi.Minivan, 1700m),
            new Araba("Volvo V60", AracTipi.StationWagon, 1600m),
            new Araba("Ford Transit", AracTipi.Panelvan, 1400m),
            new Araba("Bavaria Cruiser 46", AracTipi.Yelkenli, 5000m),
            new Araba("Princess 62", AracTipi.Motoryat, 10000m),
            new Araba("Fiat Ducato", AracTipi.Karavan, 3000m),
            new Araba("Polaris RZR", AracTipi.ATV, 1200m),
            };

            foreach (var arac in araclar)
            {
                cmbAraclar.Items.Add(arac.AracBilgisiGoster());
            }

        }
    }
}
