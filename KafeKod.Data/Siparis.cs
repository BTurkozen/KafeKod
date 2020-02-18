using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKod.Data
{
    public enum SiparisDurumu { Aktif, Odendi, Iptal }
    public class Siparis
    {
        public Siparis()
        {
            SiparisDeteylar = new List<SiparisDetay>();
        }
        public int MasaNo { get; set; }
        public DateTime? AcilisZamani { get; set; }
        public DateTime KapanisZamani { get; set; }
        public SiparisDurumu Durum { get; set; }
        public List<SiparisDetay> SiparisDeteylar { get; set; } 
        public decimal OdenenTutar { get; set; }
        public string ToplamTutarTl => string.Format("{0:0.00}₺", ToplamTutar()); // Toplam tutar seklınde bır degısken olusturarak formatstring ile toplamtutar formatını degıstırıyoruz.
        //public decimal ToplamTutar()
        //{
        //    decimal toplam = 0;
        //    foreach (var item in SiparisDeteylar)
        //    {
        //        toplam += item.Tutar();
        //    }
        //    return toplam;
        //}
        //Yukarıdaki işlem eski yontem.Asagıdaki yontem Linq ve Lambda Expresion yontemidir.
        public decimal ToplamTutar()
        {
            return SiparisDeteylar.Sum(x => x.Tutar()); // SiparisDetaylardaki Tutarları hepsini ayrı ayrı toplayarak içerisine aktarıyoruz.
        }
    }
}
