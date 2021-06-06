using BilgiOptik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOptik
{
    public partial class frmProfil : Form
    {
        int id = 0;
        BilgiOptikContext db = new BilgiOptikContext();
        Kullanici k = new Kullanici();
        public frmProfil()
        {
            InitializeComponent();
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = Program.k.kullaniciAdi;
            txtSifre.Text = Program.k.sifre;
            mtbTelefon.Text = Program.k.telefon;
            txtTCKimlikNo.Text = Program.k.TCKimlikNo.ToString();
            txtEposta.Text = Program.k.eposta;
            rtbAdres.Text = Program.k.adres;
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.Anasayfa.Show();
            this.Hide();
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" || txtSifre.Text != "" || mtbTelefon.Text != "(   )    -" || txtEposta.Text != "" || rtbAdres.Text != "")
            {
                if (cbOnay.Checked == true)
                {
                    id = Program.k.kullaniciID;
                    var ara = db.Kullanici.Find(id);
                    ara.kullaniciAdi = txtKullaniciAdi.Text;
                    ara.sifre = txtSifre.Text;
                    ara.telefon = mtbTelefon.Text;
                    ara.eposta = txtEposta.Text;
                    ara.adres = rtbAdres.Text;
                    db.SaveChanges();
                    MessageBox.Show("Bilgiler Güncellenmiştir","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Onay verilmeden güncelleme işlemi gerçekleşemez");
                }
            }
            else
            {
                MessageBox.Show("Bilgileri boş bırakamazsınız");
            }
        }
    }
}
