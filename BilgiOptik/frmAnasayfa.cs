using BilgiOptik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOptik
{
    public partial class frmAnasayfa : Form
    {
        int id = 0;
        string baslik, aciklama;
        BilgiOptikContext db = new BilgiOptikContext();
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            Listele();
            NotDefteriGoster();
        }

        public void Listele()
        {
            var liste = db.NotDefteri.Where(x => x.kullaniciID == Program.k.kullaniciID).ToList();
            lstGecmisNotlar.DataSource = liste;
            lstGecmisNotlar.ValueMember = "notDefteriID";
            lstGecmisNotlar.DisplayMember = "notu";
        }

        public void NotDefteriGoster()
        {
            if (Program.notDefteri == true)
            {
                txtBaslik.Visible = true;
                rtbMesaj.Visible = true;
                lstGecmisNotlar.Visible = true;
            }
        }

        private void btnAjanda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakında Eklenilcek...");
        }

        public void sorgu()
        {
            id = (int)lstGecmisNotlar.SelectedValue;
            var sorgu = db.NotDefteri.Find(id);
            baslik = sorgu.baslik;
            aciklama = sorgu.notu;
        }
        private void lstGecmisNotlar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sorgu();

            txtBaslik.Text = baslik;
            rtbMesaj.Text = aciklama;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.kayit.Show();
            this.Hide();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.urunler.Show();
            this.Hide();
        }

        private void btnBilgiler_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.bilgiler.Show();
            this.Hide();
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.odemeler.Show();
            this.Hide();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.satinAl.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlKategori.Width != btnMenu.Width)
            {
                pnlKategori.Width = btnMenu.Width;
            }
            else
            {
                pnlKategori.Width = btnAnasayfa.Width;
            }
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Height == 75)
            {
                pnlMenu.Height = 243;
            }
            else
            {
                pnlMenu.Height = 75;
            }
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.profilbilgi.Show();
            this.Hide();
            pnlMenu.Height = 75;
        }
        private void btnEklentiler_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.ayarlar.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.giris.Show();
            pnlMenu.Height = 75;
            pnlKategori.Width = 130;
            this.Hide();
        }

        private void btnNotDefteri_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.notDefteri.Show();
        }
    }
}
