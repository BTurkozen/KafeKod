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
    public partial class GecmisSparislerForm : Form
    {
        KafeVeri db;
        public GecmisSparislerForm(KafeVeri kafeveri)
        {
            db = kafeveri;
            InitializeComponent();
            dgvSiparisler.DataSource = db.GecmisSiparis;

        }

        private void dgvSiparisler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count > 0)
            {
                DataGridViewRow satir = dgvSiparisler.SelectedRows[0];
                Siparis siparis = (Siparis)satir.DataBoundItem;
                dgvSiparisDetaylari.DataSource = siparis.SiparisDeteylar;
            }
        }
    }
}
