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
    public partial class frmOdemeler : Form
    {

        BilgiOptikContext db = new BilgiOptikContext();

        string secilenUrunId;

        int id, urunfiyat;
        string urun;
        Musteri Ymusteri = new Musteri();
        Urun u = new Urun();
        Satis s = new Satis();




        public frmOdemeler()
        {
            InitializeComponent();
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

        private void btnCikis_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.giris.Show();
            pnlMenu.Height = 75;
            pnlKategori.Width = 130;
            this.Hide();
        }

        private void frmOdemeler_Load(object sender, EventArgs e)
        {
            if (Program.k.yetkiID==2)
            {
                btnOdemeTipleri.Visible = false;
            }
            Musteri musteri = Program.musteri;
            Urun gelenUrun = Program.urun;
            Satis gelenSatis = Program.GelenSatis;
            if (musteri != null &&gelenUrun !=null)
            {
                GelenMusteriGoster(musteri);
              

                txtOdemeTuru.Text = gelenSatis.OdemeTur.adi;
                txtPersonel.Text = db.Kullanici.Where(x => x.kullaniciID == gelenSatis.kullaniciID).Select(x => x.kullaniciAdi).SingleOrDefault();
                txtToplamTutar.Text = Convert.ToDecimal(gelenSatis.toplamTutar).ToString("c");
              
                txtUrunAdi.Text = gelenUrun.urunAdi;
            

            }

            else
            {
                btnCikisYap.Enabled = false;
            }



        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Ymusteri = null;
            txtMusteriTC.Clear();
            dgvMusteriAldiklari.DataSource = null;


            foreach (Control item in this.grpBoxMusteriBilgi.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "...";
                }


            }


            foreach (Control item in this.grpboxSiparisDetay.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "...";
                }

            }
            foreach (Control item in this.grpBoxGozNumaraları.Controls)// grouBoxGozNumaraları içersini temizler temizleme işlem
            {
                if (item is TextBox)
                {
                    item.Text = "0";
                }

            }

            btnMusteri.Enabled = true;
            btnCikisYap.Enabled = false;

        }

        private void dgvMusteriAldiklari_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void dgvMusteriAldiklari_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int siparis = (int)dgvMusteriAldiklari.CurrentRow.Cells[0].Value;
            int gozGecmisid = (int)dgvMusteriAldiklari.CurrentRow.Cells[1].Value;

            var sorgu = db.Satis.Find(siparis);
            var goz = db.GozGecmis.Find(gozGecmisid);


            var entryPoint = (from sa in db.Satis

                              where sa.satisID == siparis
                              select new
                              {
                                  SatisID = sa.satisID,
                                  GozGecmisi = sa.GozGecmis.gozGecmisID,
                                  SatanPersonel = sa.Kullanici.kullaniciAdi,
                                  UrunAdi = sa.Urun.urunAdi,
                                  Tutari = sa.toplamTutar,
                                  OdemeTipi = sa.OdemeTur.adi,
                                  UrunStandarti=sa.UrunStandart.adi,
                                  Personel = sa.Kullanici.kullaniciAdi,
                                  Tarihi = sa.tarih
                                
                            
                              }).SingleOrDefault();

            txtOdemeTuru.Text = entryPoint.OdemeTipi;
            txtPersonel.Text = entryPoint.Personel;
            txtToplamTutar.Text = Convert.ToDecimal(entryPoint.Tutari).ToString("c");
            txtStandart.Text = entryPoint.UrunStandarti;
            txtUrunAdi.Text = entryPoint.UrunAdi;
            //uzak.musteriID = Program.id;
            //uzak.solAxis = decimal.Parse(txtSolUzakAxis.Text);
            //uzak.solCyl = decimal.Parse(txtSolUzakCyl.Text);
            //uzak.solSph = decimal.Parse(txtSolUzakSph.Text);
            txtSolUzakAxis.Text = (goz.gozUzak.solAxis).ToString();
            txtSolUzakCyl.Text = (goz.gozUzak.solCyl).ToString();
            txtSolUzakSph.Text = (goz.gozUzak.solSph).ToString();
            txtSagUzakAxis.Text = (goz.gozUzak.sagAxis).ToString();
            txtSagUzakCyl.Text = (goz.gozUzak.sagCyl).ToString();
            txtSagUzakSph.Text = (goz.gozUzak.sagSph).ToString();
            txtSagDaimiAxis.Text = (goz.gozDaimi.sagAxis).ToString();
            txtSagDaimiCyl.Text = (goz.gozDaimi.sagCyl).ToString();
            txtSagDaimiSph.Text = (goz.gozDaimi.sagSph).ToString();
            txtSolDaimiAxis.Text = (goz.gozDaimi.solAxis).ToString();
            txtSolDaimiCyl.Text = (goz.gozDaimi.solCyl).ToString();
            txtSolDaimiSph.Text= (goz.gozDaimi.solSph).ToString();
            txtSagYakinAxis.Text= (goz.gozYakin.sagAxis).ToString();
            txtSagYakinCyl.Text= (goz.gozYakin.sagCyl).ToString();
            txtSagYakinSph.Text= (goz.gozYakin.sagSph).ToString();
            txtSolYakinAxis.Text= (goz.gozYakin.solAxis).ToString();
            txtSolYakinCyl.Text= (goz.gozYakin.solCyl).ToString();
            txtSolYakinSph.Text= (goz.gozYakin.solSph).ToString();  

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {

            Musteri m = db.Musteri.Where(d => d.TCKimlikNo == txtMusteriTC.Text).SingleOrDefault();

            if (m == null)
            {
                MessageBox.Show("Böyle bir müşterinin kaydı bulunmamaktadır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMusteriTC.Clear();
            }
            else
            {
                MusteriGoster(m);




                //    dgvMusteriAldiklari.DataSource = db.Satis.Where(x =>
                //    x.Musteri.TCKimlikNo == txtMusteriTC.Text).Select(x => new
                //    {

                //        MusteriAdi = x.Musteri.adi + " " + x.Musteri.soyadi,
                //        SatanPersonel = x.Kullanici.kullaniciAdi,
                //    }).ToList();

                //}



            }
        }

        private void GelenMusteriGoster(Musteri m)
        {
            MessageBox.Show("Merhaba " + m.adi + " " + m.soyadi);
            //lblMusteriId.Text = m.musteriID.ToString();
            btnMusteri.Enabled = false;
            btnCikisYap.Enabled = true;
            Ymusteri = m;


            var entryPoint = (from sa in db.Satis
                              where sa.Musteri.TCKimlikNo == m.TCKimlikNo
                              select new    
                              {
                               SatisID=sa.satisID,

                                  GozGecmisi = sa.GozGecmis.gozGecmisID,
                                  SatanPersonel = sa.Kullanici.kullaniciAdi,
                                  UrunAdi = sa.Urun.urunAdi,
                                  Tutari = sa.toplamTutar,
                                  OdemeTipi = sa.OdemeTur.adi,
                                  Tarihi = sa.tarih
                              }).ToList();



            dgvMusteriAldiklari.DataSource = entryPoint.ToList();
            dgvMusteriAldiklari.Columns["SiparisID"].Visible = false;
            dgvMusteriAldiklari.Columns["GozGecmisi"].Visible = false;


            txtMusteriAdi.Text = Ymusteri.adi +" " + Ymusteri.soyadi;
       
            txtTelefon.Text = Ymusteri.telefon.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void grpBoxGozNumaraları_Enter(object sender, EventArgs e)
        {

        }

        private void txtSolUzakCyl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSolYakinSph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSolUzakSph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSolDaimiSph_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOde_Click(object sender, EventArgs e)
        {

        }

        private void grpBoxMusteriBilgi_Enter(object sender, EventArgs e)
        {

        }

        private void grpboxSiparisDetay_Enter(object sender, EventArgs e)
        {

        }

        private void MusteriGoster(Musteri m)
        {
            MessageBox.Show("Merhaba " + m.adi + " " + m.soyadi);
            //lblMusteriId.Text = m.musteriID.ToString();
            btnMusteri.Enabled = false;
            btnCikisYap.Enabled = true;
            Ymusteri = m;


            var entryPoint = (from sa in db.Satis
                              where sa.Musteri.TCKimlikNo == txtMusteriTC.Text   
                              select new
                              {
                                  SiparisID=sa.satisID,
                                  GozGecmisi=sa.GozGecmis.gozGecmisID,
                                  SatanPersonel = sa.Kullanici.kullaniciAdi,
                                  UrunAdi = sa.Urun.urunAdi,
                                  Tutari = sa.toplamTutar,
                                  OdemeTipi = sa.OdemeTur.adi,
                                  Tarihi = sa.tarih
                              }).ToList();

           

            dgvMusteriAldiklari.DataSource = entryPoint.ToList();
            dgvMusteriAldiklari.Columns["SiparisID"].Visible = false;
            dgvMusteriAldiklari.Columns["GozGecmisi"].Visible = false;
            txtMusteriAdi.Text = Ymusteri.adi+" "+ Ymusteri.soyadi;
           
            txtTelefon.Text = Ymusteri.telefon.ToString();
        }
    }
}
