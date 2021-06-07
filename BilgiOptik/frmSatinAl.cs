using BilgiOptik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOptik
{
    public partial class frmSatinAl : Form
    {
        decimal standart = 00,
            bronz = 40,
            gumus = 60,
            altin = 80,
            platin = 100,
            elmas = 120,
            toplam = 00;
        int standartD = 1, bronzD = 2, gumusD = 3, altinD = 4, platinD = 5, elmasD = 6;

        string secilenUrunId;

        int id, urunfiyat;
        string urun;
        Musteri m = new Musteri();
        Urun u = new Urun();
        Satis s = new Satis();

        public frmSatinAl()
        {
            InitializeComponent();
        }

        BilgiOptikContext db = new BilgiOptikContext();

        private void frmSatinAl_Load(object sender, EventArgs e)
        {
            var liste = db.Urun.Where(x => x.durum == true).ToList();
            lstUrunler.DataSource = liste;
            lstUrunler.ValueMember = "modelNumarasi";
            lstUrunler.DisplayMember = "urunAdi";
            cmbOdemeTuru.DataSource = db.OdemeTur.ToList();
            cmbOdemeTuru.DisplayMember = "adi";
            cmbOdemeTuru.ValueMember = "OdemeTurID";




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

        private void rdbStandart_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbStandart.Checked == true)
            {
                toplam = urunfiyat + Convert.ToDecimal(standart);
                lblTutar.Text = toplam.ToString();
            }
        }

        private void rdbBronz_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBronz.Checked == true)
            {
                toplam = urunfiyat + Convert.ToDecimal(bronz);
                lblTutar.Text = toplam.ToString();
            }
        }

        private void rdbGumus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGumus.Checked == true)
            {
                toplam = urunfiyat + Convert.ToDecimal(gumus);
                lblTutar.Text = toplam.ToString();
            }
        }

        private void lstUrunler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            secilenUrunId = (string)lstUrunler.SelectedValue;
            UrunKontrol(secilenUrunId);
        }

        private void rdbAltin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAltin.Checked == true)
            {
                toplam = urunfiyat + Convert.ToDecimal(altin);
                lblTutar.Text = toplam.ToString();
            }
        }

        private void rdbPlatin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPlatin.Checked == true)
            {
                toplam = urunfiyat + Convert.ToDecimal(platin);
                lblTutar.Text = toplam.ToString();
            }
        }

        private void rdbElmas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbElmas.Checked == true)
            {
                toplam = urunfiyat + Convert.ToDecimal(elmas);
                lblTutar.Text = toplam.ToString();
            }
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            string musteri = txtMusteriTC.Text;
            m = db.Musteri.Where(d => d.TCKimlikNo == musteri).SingleOrDefault();

            if (m == null)
            {
                MessageBox.Show("Böyle bir müşterinin kaydı bulunmamaktadır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMusteriTC.Clear();
            }
            else
            {
                MessageBox.Show("Merhaba " + m.adi + " " + m.soyadi);
                id = m.musteriID;

            }
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            urun = txtUrun.Text;

            UrunKontrol(urun);
        }

        private void UrunKontrol(string id)
        {
            Urun u = db.Urun.Where(d => d.modelNumarasi == id).SingleOrDefault();
            txtUrun.Text = u.modelNumarasi;
            if (u == null)
            {
                MessageBox.Show("Böyle bir ürün kaydı bulunmamaktadır" +
                " \n \nYöneticinizle iletişime geçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUrun.Clear();
            }
            else if (u.stokMiktari <= 0)
            {
                MessageBox.Show(u.urunAdi + "stok bulunmamaktadır. " +
                "\n \nYöneticiniz ile iletişime geçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUrun.Clear();
            }
            else
            {
                MessageBox.Show("Ürün Adı: " + u.urunAdi + "\n\nModel Numarası: " + u.modelNumarasi +
                "\n \nÜrün Ekartmanı: " + u.urunEkartmani + "\n\nFiyatı: " + u.satisFiyat + " TL");
                lblTutar.Text = u.satisFiyat.ToString() ;
                urunfiyat = Convert.ToInt32(u.satisFiyat);

                rdbStandart.Enabled = true;
                rdbBronz.Enabled = true;
                rdbGumus.Enabled = true;
                rdbAltin.Enabled = true;
                rdbPlatin.Enabled = true;
                rdbElmas.Enabled = true;
            }
        }

        private void btnUcret_Click(object sender, EventArgs e)
        {
            urun = txtUrun.Text;
            Urun u = db.Urun.Where(d => d.modelNumarasi == urun).SingleOrDefault();

            if (id != 0 && urunfiyat != 0 && txtMusteriTC.Text != "" && txtUrun.Text != "")
            {
                s.kullaniciID = Program.k.kullaniciID;
                s.musteriID = id;
                s.toplamTutar = Convert.ToDecimal(lblTutar.Text);
                s.tarih = DateTime.Now;
                u.stokMiktari = u.stokMiktari - 1;
                s.urunID = u.urunID;
                s.odemeTurID = (int)cmbOdemeTuru.SelectedValue;
                

                if (rdbStandart.Checked == true)
                    s.urunStandartID = 1;
                

                else if (rdbBronz.Checked == true)
                    s.urunStandartID = 2;
                
                else if (rdbGumus.Checked == true)
                    s.urunStandartID = 3;
                
                else if (rdbAltin.Checked == true)
                    s.urunStandartID = 4;
                  else if (rdbPlatin.Checked == true)
                    s.urunStandartID = 5;
                
                else if (rdbElmas.Checked == true)
                    s.urunStandartID = 6;


                FormAcma.gozNumara.Show();
                Program.id = id;
                this.Hide();
                db.Satis.Add(s);
                db.SaveChanges();
                Program.SatisGozArasiID = s.satisID;
                txtMusteriTC.Clear();
                txtUrun.Clear();
                //id = 0;
                //urunfiyat = 0;
                //lblMusteriId.Text = "Id";
                //lblUrunFiyat.Text = "00";
                lblTutar.Text = "00";
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Bilgileri Doldurmadan Satın Alma İşlemini Halledemezsin", "Satın Alma Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTutar.Text = "00";
            }
        }
    }
}
