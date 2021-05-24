using BilgiOptik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOptik
{
    public partial class frmKayit : Form
    {

        BilgiOptikContext db = new BilgiOptikContext();
        Kullanici k = new Kullanici();
        Musteri m = new Musteri();
        Tedarikci t = new Tedarikci();

        public frmKayit()
        {
            InitializeComponent();
        }

        private void frmKayit_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Visible = false;
            lblSifre.Visible = false;
            txtKullaniciAdi.Visible = false;
            txtSifre.Visible = false;

            if (Program.k.yetkiID == 2)
            {
                rbMusteri.Checked = true;
                rbMusteri.Visible = false;
                rbPersonel.Visible = false;
                rbTedarikçi.Visible = false;
            }
            else
            {
                rbMusteri.Visible = true;
                rbMusteri.Checked = false;
            }
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.Anasayfa.Show();
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

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.ayarlar.Show();
            this.Hide();
        }

        //ÇALIŞAN
        private void btnMKayit_Click(object sender, EventArgs e)
        {

            //MUSTERİ
            if (rbMusteri.Checked == true && rbPersonel.Checked == false && rbTedarikçi.Checked == false)
            {
                m.kullaniciID = Program.k.kullaniciID;
                m.adi = txtAd.Text;
                m.soyadi = txtSoyad.Text;
                m.eposta = txtEposta.Text;
                m.telefon = Convert.ToDecimal(mtbTelefon.Text);
                m.TCKimlikNo = txtTCKimlik.Text;
                m.adres = rtbAdres.Text;
                db.Musteri.Add(m);
                db.SaveChanges();
                MessageBox.Show("Kayıt Edildi");
            }

            //PERSONEL
            else if (rbPersonel.Checked == true && rbMusteri.Checked == false && rbTedarikçi.Checked == false)
            {
                k.kullaniciID = Program.k.kullaniciID;
                k.yetkiID = 2;
                k.adi = txtAd.Text;
                k.soyadi = txtSoyad.Text;
                k.eposta = txtEposta.Text;
                k.telefon = mtbTelefon.Text;
                k.TCKimlikNo = txtTCKimlik.Text;
                k.adres = rtbAdres.Text;
                k.kullaniciAdi = txtKullaniciAdi.Text;
                k.sifre = txtSifre.Text;
                db.Kullanici.Add(k);
                db.SaveChanges();
                MessageBox.Show("Kayıt Edildi");
            }

            //TEDARİKÇİ
            else if (rbTedarikçi.Checked == true && rbMusteri.Checked == false && rbPersonel.Checked == false)
            {
                t.kullaniciID = Program.k.kullaniciID;
                t.tedarikciAdi = txtAd.Text;
                t.firmaAdi = txtSoyad.Text;
                t.eposta = txtEposta.Text;
                t.telefon = Convert.ToDecimal(mtbTelefon.Text);
                t.faks = Convert.ToInt32(txtTCKimlik.Text);
                t.adres = rtbAdres.Text;
                db.Tedarikci.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kayıt Edildi");
            }
            else
            {
                MessageBox.Show("Bir kayıt türü seçiniz");
            }

        }

        private void rbMusteri_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMusteri.Checked == true)
            {
                btnMKayit.Enabled = true;
                lblKullaniciAdi.Visible = false;
                lblSifre.Visible = false;
                txtKullaniciAdi.Visible = false;
                txtSifre.Visible = false;
            }
        }

        private void rbPersonel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPersonel.Checked == true)
            {
                btnMKayit.Enabled = true;
                lblKullaniciAdi.Visible = true;
                lblSifre.Visible = true;
                txtKullaniciAdi.Visible = true;
                txtSifre.Visible = true;

            }
        }

        private void rbTedarikçi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTedarikçi.Checked == true)
            {
                btnMKayit.Enabled = true;
                lblKullaniciAdi.Visible = false;
                lblSifre.Visible = false;
                txtKullaniciAdi.Visible = false;
                txtSifre.Visible = false;
            }
            //if (rbTedarikçi.Checked == true)
            //{
            //    kb.TedarikciEkleme(new Tedarikci()
            //    {
            //        kullaniciID = Program.k.kullaniciID,
            //        firmaAdi = txtAd.Text,
            //        tedarikciAdi = txtSoyad.Text,
            //        tedarikciVergiNo = txtEposta.Text,
            //        telefon = Convert.ToInt32(txtTelefon.Text),
            //        faks = Convert.ToInt32(txtTCKimlik.Text),
            //        eposta = txtKAdres.Text
            //    });
            //}
            //MessageBox.Show("Kayıt Edildi");
            //this.Close();
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

        private void btnCikis_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.giris.Show();
            pnlMenu.Height = 75;
            pnlKategori.Width = 130;
            this.Hide();
        }
    }
}