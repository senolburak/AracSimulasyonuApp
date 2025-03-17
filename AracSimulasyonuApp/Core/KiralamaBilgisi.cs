﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AracSimulasyonuApp.Core
{
    public class KiralamaBilgisi
    {
        public string AracModel { get; set; }
        public int  GunSayisi { get; set; }
        public decimal  ToplamUcret { get; set; }

        public override string ToString()
        {
            return $"{AracModel} - {GunSayisi} - {ToplamUcret}";
        }
    }
}
