using System.Reflection;
using System.Text.Json;
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

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            if (cmbAraclar.SelectedIndex == -1 || !int.TryParse(txtGunSayisi.Text, out int gunSayisi) || gunSayisi < 0)
            {
                MessageBox.Show("Lütfen geçerli bir araç seçiniz veya Lütfen geçerli bir Sayý Giriniz");
                return;
            }
            IArac secilenArac = araclar[cmbAraclar.SelectedIndex];

            if (!secilenArac.MusaitMi)
            {
                MessageBox.Show("Araç Þuanda Kirada");
                return;
            }
            decimal toplamUcret = secilenArac.GunlukUcret * gunSayisi;

            if (gunSayisi >= 5)
            {
                toplamUcret *= 0.9m;
            }

            KiralamaBilgisi yeniKiralama = new KiralamaBilgisi
            {
                AracModel = secilenArac.Model,
                GunSayisi = gunSayisi,
                ToplamUcret = toplamUcret
            };
            kiralananAraclar.Add(yeniKiralama);
            lsbKiralananArac.Items.Add(yeniKiralama);

            secilenArac.MusaitMi = false;

            cmbAraclar.Items[cmbAraclar.SelectedIndex] = $"{secilenArac.Model} - {secilenArac.Tip} Günlük Ücret - {secilenArac.GunlukUcret}";

            lblSonuc.Text = $"Toplam Ücret: {toplamUcret}";

        }
        private void JsonVeriKaydet()
        {
            try
            {
                string projeDizini = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string hedefDizini = Path.Combine(projeDizini, @"..\..\..\", "Data");
                string dosyaYolu = Path.Combine(hedefDizini, "data.json");

                if (!Directory.Exists(hedefDizini))
                {
                    Directory.CreateDirectory(hedefDizini);
                }
                List<KiralamaBilgisi> mevcutVeriler = new List<KiralamaBilgisi>();
                if (!File.Exists(dosyaYolu))
                {
                    mevcutVeriler = new List<KiralamaBilgisi>();
                }
                else
                {
                    string eskiJson = File.ReadAllText(dosyaYolu);
                    var veriListesi = JsonSerializer.Deserialize<List<KiralamaBilgisi>>(eskiJson);
                    if (veriListesi == null)
                    {
                        return;
                    }
                    mevcutVeriler = veriListesi;
                }
                mevcutVeriler.AddRange(kiralananAraclar);
                var jsonAyar = new JsonSerializerOptions { WriteIndented = true };
                string yeniJson = JsonSerializer.Serialize(mevcutVeriler, jsonAyar);
                File.WriteAllText(dosyaYolu, yeniJson);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnJsonVeriOluþtur_Click(object sender, EventArgs e)
        {
            JsonVeriKaydet();
        }
    }
}
