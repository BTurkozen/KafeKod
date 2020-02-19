using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKod.Data
{
    public class KafeVeri
    {
        public KafeVeri()
            {
            
            Urunler = new List<Urun>(); // Urunlerden list olusturarak Urunleri buraya aktarıyoruz.
            AktifSiparis = new List<Siparis>(); // Siparis clasından liste olusturarak Aktifsiparislerimizi tutmamıza olanak saglıyor.
            GecmisSiparis = new List<Siparis>();  // Siparis clasından liste olusturarak GecmisSparis tutmamıza olanak saglıyor.
        }
        // Propertieslerimizi oluşturuyoruz.
        public  List<Urun> Urunler { get; set; }
        public List<Siparis> AktifSiparis { get; set; }
        public List<Siparis> GecmisSiparis { get; set; }
        public int MasaAdet { get; set; } = 20;
    }
}
