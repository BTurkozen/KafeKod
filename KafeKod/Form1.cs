using KafeKod.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeKod
{
    public partial class Form1 : Form
    {
        KafeVeri db;
      
        //KafeKod.Datayi referance/ addreferance/ oradan KafeKod.Datayi ekleyerek referans gösterebiliyoruz.
        
        public Form1()
        {
            VerileriOku();
            InitializeComponent();            
            MasalariOlustur();

        }

        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                db = JsonConvert.DeserializeObject<KafeVeri>(json);
            }
            catch (Exception)
            {

                db = new KafeVeri();
            }
        }

        private void OrnekVerileriYukle()
        {
            db.Urunler = new List<Urun>
            {
               // Urunler Listemize default urun eklıyoruz.
                new Urun { UrunAd = "Ayran", BirimFiyat = 3.50m },
                new Urun {UrunAd = "Çay", BirimFiyat = 4.00m}
            };
            db.Urunler.Sort();
        }

        private void MasalariOlustur()
        {
            #region ListView imaj listesini oluşturalım.
            ImageList il = new ImageList(); // imagelist olarak oluşturuyoruz.
            il.Images.Add("bos", Properties.Resources.masabos); // boş ise resource deki nmasabos imageni alıyor
            il.Images.Add("dolu", Properties.Resources.masadolu); // dolu ise resource deki nmasadolu imageni alıyor
            il.ImageSize = new Size(64,64); // Resimin sizeni 64,64 kare olarak oluşturuyoruz.
            lvwMasalar.LargeImageList = il; //Resmi buyuk göstermek için kullanıyoruz. 
            #endregion

            ListViewItem lvi;

            for (int i = 1; i <= db.MasaAdet; i++)
            {
                lvi = new ListViewItem("Masa " + i); // lvi ile masa oluşturup i ile masaAdet kadar masa ekliyoruz.
                //i masa no ile kayıtlı bir sipariş varmı 
                Siparis sip = db.AktifSiparis.FirstOrDefault(x => x.MasaNo == i);

                if (sip == null)
                {
                    lvi.Tag = 1;
                    lvi.ImageKey = "bos";
                }
                else
                {
                    lvi.Tag = sip;
                    lvi.ImageKey = "dolu";
                }
                lvwMasalar.Items.Add(lvi); // listviewimize lvi de oluşturdugumuz masalari ekliyoruz.
                
               
            }
        }

        private void lvwMasalar_MouseDoubleClick(object sender, MouseEventArgs e) // doubleClick eventini kullanmamamizin sebebi eventsecenegi bunun daha cok olmasından dolayı.
        {
            if (e.Button == MouseButtons.Left)// Mousun sadece sol tusuna çift tıklandıgında işlem yapması için. 
            {
                lvwMasalar.SelectedItems[0].ImageKey = "dolu";// Cift tıkladıgımızda oge dolu olarak gozukmesıni saglıyoruz.

                //Masa Boşsa Yeni Şipariş Oluştur.
                var lvi = lvwMasalar.SelectedItems[0];
                lvi.ImageKey = "dolu";

                Siparis sip;
                if ((lvi.Tag is Siparis))
                {
                    sip = (Siparis)lvi.Tag;   
                }
                else
                {
                    sip = new Siparis();
                    sip.MasaNo = (int)lvi.Tag;
                    sip.AcilisZamani = DateTime.Now;
                    lvi.Tag = sip;
                    db.AktifSiparis.Add(sip);
                }

                MasaDetayForm frmSipraris = new MasaDetayForm(db, sip);
                frmSipraris.MasaTasindi += FrmSipraris_MasaTasindi;
                frmSipraris.ShowDialog();

                if (sip.Durum != SiparisDurumu.Aktif)
                {
                    lvi.Tag = sip.MasaNo;
                    lvi.ImageKey = "bos";
                    db.AktifSiparis.Remove(sip);
                    db.GecmisSiparis.Add(sip);
                }
            }
        }

        private void FrmSipraris_MasaTasindi(object sender, MasaTasimaEventArgs e)
        {
            //adım 1 Eski Masayi boşalt
            ListViewItem lviEskiMasa = null;
            foreach (ListViewItem item in lviMasalar.Items)
            {
                if (item.Tag == e.EskiMasaNo)
                {
                    lviEskiMasa = item;
                    break;
                }
                lviEskiMasa.Tag = e.EskiMasaNo;
                lviEskiMasa.ImageKey = "bos";
            }


           //adım 2 Yeni masaya sipariş koy.


        }

        private void tsmiGecmisUrunler_Click(object sender, EventArgs e)
        {
            var frm = new GecmisSparislerForm(db);
            frm.ShowDialog();
        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            var frm = new UrunlerForm(db);
            frm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(db);
            File.WriteAllText("veri.json", json);
        }
    }
}
