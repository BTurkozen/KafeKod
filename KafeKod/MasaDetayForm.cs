using KafeKod.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeKod
{
    public partial class MasaDetayForm : Form
    {
        KafeVeri db; // Constructer için field olusturuyoruz.
        Siparis siparis; // Constructer için field olusturuyoruz.
        BindingList<SiparisDetay> blSiparisDetaylar;

        public MasaDetayForm(KafeVeri kafeVeri, Siparis siparis)
        {
            db = kafeVeri; //  Yukarıda olusturdugumuz fieldleri buraya aktarıyoruz.
            this.siparis = siparis; // Yukarıda olusturdugumuz fieldleri buraya aktarıyoruz.
            blSiparisDetaylar = new BindingList<SiparisDetay>(siparis.SiparisDeteylar);
            InitializeComponent();
            MasaNoGuncelle();
            TutarGuncelle();
            cboMasaUrun.DataSource = db.Urunler;
            cboMasaUrun.SelectedItem = null;
            dgvSiparisDetaylari.DataSource = blSiparisDetaylar;

        }

        private void TutarGuncelle()
        {
            lblMasaTutar.Text = siparis.ToplamTutarTl;
        }

        private void MasaNoGuncelle()
        {
            Text = "Masa " + siparis.MasaNo; // Yukarıda olusturdugumuz constructer ile formumuzun text'tine Masa ve masanumarasını aktarıyoruz.
            lblMasaNo.Text = siparis.MasaNo.ToString("00"); // masanumarası labelımızın textini ustte tanımladıgımız sekılde aktarıyoruz ve formatınıda 01 02 seklinde olusturmamaızı saglıyor.
        }

        private void btnMasaEkle_Click(object sender, EventArgs e)
        {
            if (cboMasaUrun.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Bir Ürün Seçiniz...");
                return;
            }
            Urun seciliUrun = (Urun)cboMasaUrun.SelectedItem;
            var sd = new SiparisDetay
            {
                UrunAd = seciliUrun.UrunAd,
                BirimFiyat = seciliUrun.BirimFiyat,
                Adet = (int)nudMasaAdet.Value
            };
            blSiparisDetaylar.Add(sd);
            nudMasaAdet.Value = 1;
            TutarGuncelle();
            
        }

        private void btnMasaAnaSayfa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMasaSiparisIptal_Click(object sender, EventArgs e)
        {
            siparis.Durum = SiparisDurumu.Iptal;
            var dr = MessageBox.Show("Sipariş iptal edilecektir Onaylıyor musunuz?", "Sipariş İptal Onayı", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning, 
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                siparis.Durum = SiparisDurumu.Iptal;
                siparis.KapanisZamani = DateTime.Now;
                Close();
            }
            
        }

        private void btnMasaOdemeAl_Click(object sender, EventArgs e)
        {
            siparis.Durum = SiparisDurumu.Odendi;
            var dr = MessageBox.Show("Ödeme alındıysa hesap kapatılacaktır. Onaylıyor musunuz?", "Hesap Kapatma Onayı", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                siparis.Durum = SiparisDurumu.Odendi;
                siparis.KapanisZamani = DateTime.Now;
                siparis.OdenenTutar = siparis.ToplamTutar();
                Close();
            }
        }
    }
}
