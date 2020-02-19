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
        public event EventHandler<MasaTasimaEventArgs> MasaTasindi;

        KafeVeri db; // Constructer için field olusturuyoruz.
        Siparis siparis; // Constructer için field olusturuyoruz.
        BindingList<SiparisDetay> blSiparisDetaylar;

        public MasaDetayForm(KafeVeri kafeVeri, Siparis siparis)
        {
            db = kafeVeri; //  Yukarıda olusturdugumuz fieldleri buraya aktarıyoruz.
            this.siparis = siparis; // Yukarıda olusturdugumuz fieldleri buraya aktarıyoruz.
            blSiparisDetaylar = new BindingList<SiparisDetay>(siparis.SiparisDeteylar);
            InitializeComponent();
            MasaNolariniYukle();
            MasaNoGuncelle();
            TutarGuncelle();
            cboMasaUrun.DataSource = db.Urunler.OrderBy(x => x.UrunAd).ToList(); // combobox'in  property'sinde  combobox sıralama yapabılıyoruz.
            cboMasaUrun.SelectedItem = null;
            dgvSiparisDetaylari.DataSource = blSiparisDetaylar;

        }

        private void MasaNolariniYukle()
        {
            cboMasaNo.Items.Clear();
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                if (!db.AktifSiparis.Any(x => x.MasaNo == i))
                {
                    cboMasaNo.Items.Add(i);
                }
            }
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

        private void dgvSiparisDetaylari_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int satirIndex = dgvSiparisDetaylari.HitTest(e.X, e.Y).RowIndex;
                if (satirIndex > -1)
                {
                    dgvSiparisDetaylari.ClearSelection();
                    dgvSiparisDetaylari.Rows[satirIndex].Selected = true;
                    cmsSiparisDetay.Show(MousePosition); //MousePosition yerine Cursor.Position kullanabiliriz.
                }


            }
        }

        private void tsmSiparisDetaySil_Click(object sender, EventArgs e)
        {
            if (dgvSiparisDetaylari.SelectedRows.Count > 0)
            {
                var seciliSatir = dgvSiparisDetaylari.SelectedRows[0];
                var sipDetay = (SiparisDetay)seciliSatir.DataBoundItem;
                blSiparisDetaylar.Remove(sipDetay);
            }

            TutarGuncelle();
        }

        private void btnMasaTasi_Click(object sender, EventArgs e)
        {
            if (cboMasaNo.SelectedItem == null)
            {
                MessageBox.Show("Lütfen hedef masa noyu seçiniz.");
                return;
            }

            int eskiMasaNo = siparis.MasaNo;
            int hedefMasa = (int)cboMasaNo.SelectedItem;
            siparis.MasaNo = hedefMasa;
            MasaNoGuncelle();
            MasaNolariniYukle();
            if (MasaTasindi != null)
            {
                var args = new MasaTasimaEventArgs
                {
                    TasinanSiparis = siparis,
                    EskiMasaNo = eskiMasaNo,
                    YeniMasaNo = hedefMasa
                };
                MasaTasindi(this, args);
            }
        }
    }

    public class MasaTasimaEventArgs : EventArgs
    {
        public Siparis TasinanSiparis { get; set; }
        public int YeniMasaNo { get; set; }
        public int EskiMasaNo { get; set; }
    }
}
