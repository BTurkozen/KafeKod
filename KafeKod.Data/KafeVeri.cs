﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKod.Data
{
    class KafeVeri
    {
        public  List<Urun> Urunler { get; set; }
        public List<Siparis> AktifSiparis { get; set; }
        public List<Siparis> GecmisSiparis { get; set; }
    }
}
