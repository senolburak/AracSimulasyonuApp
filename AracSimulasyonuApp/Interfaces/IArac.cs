using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracSimulasyonuApp.Enum;

namespace AracSimulasyonuApp.Interfaces
{
    public interface IArac
    {
        
        string Model { get; }
        AracTipi Tip { get; }
        decimal GunlukUcret { get; }
        bool MusaitMi { get; set; }

        
        string AracBilgisiGoster();
        

        
    }
}
