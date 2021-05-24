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
    public partial class frmBilgiler : Form
    {


        Tedarikci tedarikci = new Tedarikci();
        Musteri musteri = new Musteri();
        Kullanici kullanici = new Kullanici();


        public frmBilgiler()
        {
            InitializeComponent();
        }

        BilgiOptikContext db = new BilgiOptikContext();

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

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void frmBilgiler_Load(object sender, EventArgs e)
        {
            rbMusteriler.Checked = true;

        }

        private void TedarikCiGoster()
        {
            lstbxListele.DataSource = db.Tedarikci.Where(x => x.durum == true).Select(x => new { x.firmaAdi, x.tedarikciID }).ToList();
            lstbxListele.DisplayMember = "firmaAdi";
            lstbxListele.ValueMember = "tedarikciID";
        }
        private void PersonelGoster()
        {

            //var sorgu = db.Kullanici.Where(x => x.durum == true).Select(x => new { x.kullaniciAdi, x.kullaniciID }).ToList();

            //lstbxListele.DataSource = sorgu;
            //lstbxListele.DisplayMember = "kullaniciAdi";
            //lstbxListele.ValueMember = "kullaniciID";

        }
        private void MusteriGoster()
        {
            lstbxListele.DataSource = db.Musteri.Select(x => new { AdSoyad = x.adi + " " + x.soyadi, x.musteriID }).ToList();
            lstbxListele.DisplayMember = "AdSoyad";
            lstbxListele.ValueMember = "musteriID";

        }

        private void rbTedarikciler_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();
            if (rbTedarikciler.Checked == true)
            {
                lblDeger1.Visible = true;
                txtDeger1.Visible = true;
                lblDeger2.Visible = true;
                txtDeger2.Visible = true;
                txtDeger3.Visible = true;
                lbldeger3.Visible = true;
                lbldeger3.Text = "Firma Adı";
                lblDeger1.Text = "Faks";
                lblDeger2.Text = "Vergi No";

                TedarikCiGoster();

            }

        }

        private void rbPersoneller_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();
            if (rbPersoneller.Checked == true)
            {
                lblDeger2.Visible = true;
                lblDeger1.Visible = true;
                txtDeger1.Visible = true;
                txtDeger2.Visible = true;
                txtDeger3.Visible = true;
                lbldeger3.Visible = true;

                lblDeger1.Text = "Tc kimlik No";
                lbldeger3.Text = "Kullanici Adi";
                lblDeger2.Text = "Yetki";
                PersonelGoster();


            }
        }
        public void Temizle()
        {
            foreach (Control item in this.grboxBilgiler.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = null;
                }


            }

        }
        private void rbMusteriler_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();

            if (rbMusteriler.Checked == true)
            {
                lblDeger1.Visible = false;
                txtDeger1.Visible = false;
                lblDeger2.Visible = false;
                txtDeger2.Visible = false;
                txtDeger3.Visible = false;
                lbldeger3.Visible = false;

                MusteriGoster();


            }
        }



        int id = 0;
        private void lstbxListele_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //foreach (Control item in this.grboxTedarikci.Controls)
            //{
            //    if (item is TextBox)
            //    {
            //        item.Text = null;
            //    }


            //}


            if (rbMusteriler.Checked == true)
            {
                id = (int)lstbxListele.SelectedValue;

                var sorgu = db.Musteri.Find(id);

                txtAd.Text = sorgu.adi;
                txtSoyadi.Text = sorgu.soyadi;
                txtTelefon.Text = sorgu.telefon.ToString();
                txtEposta.Text = sorgu.eposta;
                txtAdres.Text = sorgu.adres;



            }
            else if (rbTedarikciler.Checked == true)
            {
                id = (int)lstbxListele.SelectedValue;
                var sorgu = db.Tedarikci.Find(id);
                txtAd.Text = sorgu.tedarikciAdi;
                //txtSoyadi.Text = sorgu.tedarikciSoyadi;
                txtTelefon.Text = sorgu.telefon.ToString();
                txtEposta.Text = sorgu.eposta;
                txtAdres.Text = sorgu.adres;


                txtDeger2.Text = sorgu.tedarikciVergiNo;
                txtDeger1.Text = sorgu.faks.ToString();
                txtDeger3.Text = sorgu.firmaAdi;






            }
            else if (rbPersoneller.Checked == true)
            {
                id = (int)lstbxListele.SelectedValue;
                var sorgu = db.Kullanici.Find(id);
                txtAd.Text = sorgu.adi;
                txtSoyadi.Text = sorgu.soyadi;
                txtTelefon.Text = sorgu.telefon.ToString();
                txtEposta.Text = sorgu.eposta;
                txtAdres.Text = sorgu.adres;
                txtDeger1.Text = sorgu.TCKimlikNo;
                txtDeger3.Text = sorgu.kullaniciAdi;
                txtDeger2.Text = sorgu.Yetki.adi;

            }




        }
    }
}
