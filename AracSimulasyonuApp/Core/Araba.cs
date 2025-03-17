using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracSimulasyonuApp.Enum;
using AracSimulasyonuApp.Interfaces;

namespace AracSimulasyonuApp.Core
{
    public class Araba : IArac
    {
        public Araba(string model,AracTipi tip,decimal gunlukUcret)
        {
            Model = model;
            Tip = tip;
            GunlukUcret = gunlukUcret;
        }
        public string Model { get; }

        public AracTipi Tip { get; }

        public decimal GunlukUcret { get; }

        public bool MusaitMi { get; set; } = true;

        public string AracBilgisiGoster()
        {
            return $"{Model} - {Tip} - {GunlukUcret} - Listelendi";
        }
    }
}
