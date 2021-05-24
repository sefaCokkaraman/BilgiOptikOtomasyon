using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgiOptik.Model;
using BilgiOptik.Model.Views;

namespace BilgiOptik
{
    public partial class frmGelirGider : Form
    {
        public frmGelirGider()
        {
            InitializeComponent();
        }
        BilgiOptikContext db = new BilgiOptikContext();
        Dictionary<int, string> dicTarihListele = new Dictionary<int, string>();
        object selectSorgusu;





        #region Form Butonları




        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FormAcma.Anasayfa.Show();
            this.Hide();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            FormAcma.kayit.Show();

            this.Hide();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FormAcma.urunler.Show();
            this.Hide();
        }

        private void btnBilgiler_Click(object sender, EventArgs e)
        {
            FormAcma.bilgiler.Show();
            this.Hide();
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            FormAcma.odemeler.Show();

            this.Hide();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            FormAcma.satinAl.Show();
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FormAcma.ayarlar.Show();
            this.Hide();
        }


        #endregion
        private void frmGelirGider_Load(object sender, EventArgs e)
        {

            dgwgelir.DataSource = db.Satis.Select(x => new
            {
                x.satisID,
                personelAd = x.Kullanici.kullaniciAdi,
                musteriAdSoyad = x.Musteri.adi + " " + x.Musteri.soyadi,
                toplamTutar = x.toplamTutar,
                odemeTipi = x.OdemeTur.adi,
                islemTarihi = x.tarih

            }).ToList();


            dicTarihListele.Add(0, "Hepsini Göster");
            dicTarihListele.Add(1, "Bugün");
            dicTarihListele.Add(2, "Son 3 gün");
            dicTarihListele.Add(3, "son 1 hafta");
            dicTarihListele.Add(4, "Son 1 ay");
            dicTarihListele.Add(5, "Son 6 ay");
            dicTarihListele.Add(6, "Son 1 yıl");
            cmbTarihSecim.DataSource = dicTarihListele.ToList();
            cmbTarihSecim.DisplayMember = "Value";
            cmbTarihSecim.ValueMember = "Key";

            cmbListele.Items.Add("Arama Tipi Seçiniz");
            cmbListele.Items.Add("Personel Kullanici Adına göre Sırala");
            cmbListele.Items.Add("Müşteri Adına göre Sırala");

            cmbListele.SelectedIndex = 0;


            #region Sayısalbilgiler
            using (ViewContext view = new ViewContext())
            {
                lblEncokSatilanUrunDegeri.Text = view.EnCokSatilanUrunler_view.Select(x => x.urunAdi).FirstOrDefault().ToString();
                lblToplamUrunSayısıDegeri.Text = db.Urun.Select(x => x.urunID).Count().ToString();
                lblEnCokSatisYapanPersonelDegeri.Text = view.EncokSatisYapanPersoneller_view.OrderByDescending(x => x.ToplamSatis
                ).Select(x => x.kullaniciAdi).FirstOrDefault().ToString();

                List<decimal> toplamSatis = db.Satis.Select(x => x.toplamTutar.Value).ToList();
                lblSatilanUrunlerFiyatlarıToplamiDeger.Text = toplamSatis.Sum().ToString();

                lblToplamPersonelSayisiDeger.Text = db.Kullanici.Select(x => x.kullaniciID).Count().ToString();

                lblPersonelSatisDeger.Text = view.EncokSatisYapanPersoneller_view.OrderByDescending(x => x.ToplamSatis
                ).Select(x => x.ToplamSatis).FirstOrDefault().ToString();
                //lblEncokSatilanUrunDegeri.Text = db.Urun.Select(x => x.urunID).Count().ToString();

                //Pesonelin kaç tane ürün kayıtı yaptıgı




                //Toplam Harcama
                //


            }
            #endregion

            selectSorgusu = db.Satis.Select(x => new
            {
                x.satisID,
                MusteriAdSoyad = x.Musteri.adi + " " + x.Musteri.soyadi,
                x.Kullanici.kullaniciAdi,
                x.toplamTutar,
                x.OdemeTur.adi,
                x.tarih,
            });

        }

        private void dgvSatinAl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }



        private void cmbTarihSecim_SelectedIndexChanged(object sender, EventArgs e)
        {


            TarihDondur(cmbTarihSecim.SelectedIndex);


        }
        void TarihDondur(int i)
        {
            //object satisgoster = db.Satis.Select(x => new
            //{
            //    x.satisID,
            //    MusteriAdSoyad = x.Musteri.adi + " " + x.Musteri.soyadi,
            //    x.Kullanici.kullaniciAdi,
            //    x.toplamTutar,
            //    x.OdemeTur.Adi,
            //    x.tarih,


            //});

            List<DateTime> dateTimes = new List<DateTime>();

            TimeSpan timeSpan;


            var bugun = DateTime.Today;
            if (i == 0)//TümVeriler
            {
                SatisGoster();

            }//TümVeriler

            else if (i == 1)
            {
                dgwgelir.DataSource = db.Satis.Select(x => new
                {
                    x.satisID,
                    MusteriAdSoyad = x.Musteri.adi + " " + x.Musteri.soyadi,
                    x.Kullanici.kullaniciAdi,
                    x.toplamTutar,
                    x.OdemeTur.adi,
                    x.tarih,


                }).Where(x => x.tarih >= bugun).ToList();
            }//Bugunun verileri

            else if (i == 2)
            {

                //timeSpan= new TimeSpan(3, 0, 0, 0);
                //var seciliZaman = Convert.ToDateTime(bugun - timeSpan);
                var seciliZaman = bugun.AddDays(-3);
                dgwgelir.DataSource = db.Satis.Select(x => new
                {
                    x.satisID,
                    MusteriAdSoyad = x.Musteri.adi + " " + x.Musteri.soyadi,
                    x.Kullanici.kullaniciAdi,
                    x.toplamTutar,
                    x.OdemeTur.adi,
                    x.tarih,


                }).Where(x => x.tarih >= seciliZaman).ToList();


            }//Son 3 günün verileri

            else if (i == 3)//Son 1 haftanın verileri
            {
                timeSpan = new TimeSpan(7, 0, 0, 0);
                var seciliZaman = Convert.ToDateTime(bugun - timeSpan);
                dgwgelir.DataSource = db.Satis.Select(x => new
                {
                    x.satisID,
                    MusteriAdSoyad = x.Musteri.adi + " " + x.Musteri.soyadi,
                    x.Kullanici.kullaniciAdi,
                    x.toplamTutar,
                    x.OdemeTur.adi,
                    x.tarih,


                }).Where(x => x.tarih >= seciliZaman).ToList();


            }

            else if (i == 4)
            {

                var seciliZaman = bugun.AddMonths(-1);
                dgwgelir.DataSource = db.Satis.Select(x => new
                {
                    x.satisID,
                    MusteriAdSoyad = x.Musteri.adi + " " + x.Musteri.soyadi,
                    x.Kullanici.kullaniciAdi,
                    x.toplamTutar,
                    x.OdemeTur.adi,
                    x.tarih,


                }).Where(x => x.tarih >= seciliZaman).ToList();

            }//Son 1 ayın 

            else if (i == 5)
            {

                var seciliZaman = bugun.AddMonths(-6);
                dgwgelir.DataSource = db.Satis.Select(x => new
                {
                    x.satisID,
                    MusteriAdSoyad = x.Musteri.adi + " " + x.Musteri.soyadi,
                    x.Kullanici.kullaniciAdi,
                    x.toplamTutar,
                    x.OdemeTur.adi,
                    x.tarih,


                }).Where(x => x.tarih >= seciliZaman).ToList();

            }//son 3 ay
            else if (i == 6)
            {

                var seciliZaman = bugun.AddYears(-1);
                dgwgelir.DataSource = db.Satis.Select(x => new
                {
                    x.satisID,
                    MusteriAdSoyad = x.Musteri.adi + " " + x.Musteri.soyadi,
                    x.Kullanici.kullaniciAdi,
                    x.toplamTutar,
                    x.OdemeTur.adi,
                    x.tarih,


                }).Where(x => x.tarih >= seciliZaman).ToList();

            }//son 1 yıl



        }

        private void SatisGoster()
        {
            dgwgelir.DataSource = db.Satis.Select(x => new
            {
                x.satisID,
                MusteriAdSoyad = x.Musteri.adi + " " + x.Musteri.soyadi,
                x.Kullanici.kullaniciAdi,
                x.toplamTutar,
                x.OdemeTur.adi,
                x.tarih,


            }).ToList();


        }


        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            SatisGridGoster();

        }

        private object SatisGosterKullaniciAdi(string key)
        {

            //var result = (from p in db.Satis 
            //              where p.Kullanici.kullaniciAdi.Contains(key)
            //              select new {p.satisID,p.tarih} ); /////////////////////////////////////Mantık Aynı 

            var sorgu = db.Satis.Select(x => new
            {
                x.satisID,
                MusteriAdSoyad = x.Musteri.adi + " " + x.Musteri.soyadi,
                x.Kullanici.kullaniciAdi,
                x.toplamTutar,
                x.OdemeTur.adi,
                x.tarih,
            }).Where(x => x.kullaniciAdi.Contains(key)).ToList();
            return sorgu;
        }
        private object SatisGosterMusteriAdi(string key)
        {
            var sorgu = db.Satis.Select(x => new
            {
                x.satisID,
                MusteriAdSoyad = x.Musteri.adi + " " + x.Musteri.soyadi,
                x.Kullanici.kullaniciAdi,
                x.toplamTutar,
                x.OdemeTur.adi,
                x.tarih,
            }).Where(x => x.MusteriAdSoyad.Contains(key)).ToList();
            return sorgu;
        }

        private void SatisGridGoster()
        {
            if (txtAra.Text == null || cmbListele.SelectedIndex == 0)
                SatisGoster();
            else
            {
                if (cmbListele.SelectedIndex == 1)
                {

                    dgwgelir.DataSource = SatisGosterKullaniciAdi(txtAra.Text);

                }
                else if (cmbListele.SelectedIndex == 2)
                {

                    dgwgelir.DataSource = SatisGosterMusteriAdi(txtAra.Text);
                }

            }

        }

        decimal toplamPara;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (rbTedarikciGider.Checked == true)
            {
                dgwgelir.DataSource = db.TedarikciGider.Select(x => new
                {
                    ID = x.tedarikciGiderID,
                    FirmaAdi = x.Tedarikci.firmaAdi,
                    ÖdemeTürü = x.OdemeTur.adi,
                    UrunModelNumarası = x.Urun.modelNumarasi,
                    Miktarı = x.miktar,
                    BirimFiyatı = x.birimFiyat,
                    ToplamTutar = x.toplamTutar,
                    EklenmeTarihi = x.eklenmeTarihi
                }).ToList();
            }



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSatislar.Checked == true)
            {
                SatisGoster();

            }
        }
        private void pdSatis_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font baslik = new Font("Verdana", 12, FontStyle.Bold);
            Font Govde = new Font("Verdana", 12);
            SolidBrush sb = new SolidBrush(Color.Black);

            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(" Hesap Haraketleri", baslik, sb, 200, 100);


            if (rbSatislar.Checked == true)
            {
                toplamPara = 0;
                e.Graphics.DrawString("ID       Musteri                 Personel          Toplam Tutar         Tarihi", baslik, sb, 30, 150);
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", baslik, sb, 30, 170);
                for (int i = 0; i < dgwgelir.Rows.Count; i++)
                {

                    decimal para = (decimal)dgwgelir.Rows[i].Cells[3].Value;
                    DateTime date =(DateTime)dgwgelir.Rows[i].Cells[5].Value;
         
                    e.Graphics.DrawString(dgwgelir.Rows[i].Cells[0].Value + " ", Govde, sb, 30, 190 + (i * 30));
                    e.Graphics.DrawString(dgwgelir.Rows[i].Cells[1].Value + " ", Govde, sb, 100, 190 + (i * 30));
                    e.Graphics.DrawString(dgwgelir.Rows[i].Cells[2].Value + " ", Govde, sb, 270, 190 + (i * 30));
                    e.Graphics.DrawString(para.ToString("c"), Govde, sb, 420, 190 + (i * 30));
                    e.Graphics.DrawString(date.ToShortDateString(), Govde, sb, 600, 190 + (i * 30));
                    toplamPara += para;
                }
                e.Graphics.DrawString("---------------------------------------------------------------------------------------------", baslik, sb, 30, dgwgelir.Rows.Count * 30);
                e.Graphics.DrawString("Toplam Tutar : " + toplamPara.ToString("c"), baslik, sb, 500, (dgwgelir.Rows.Count*30)+200);
            }
  
            else
            {
                toplamPara = 0;   
             
                e.Graphics.DrawString("ID    Firma Adı           Model Numarası      Miktarı      Toplam Tutar         Tarihi", baslik, sb, 30, 150);
                e.Graphics.DrawString("---------------------------------------------------------------------------------------------", baslik, sb, 30, 170);
                for (int i = 0; i < dgwgelir.Rows.Count; i++)
                {
                    DateTime date = (DateTime)dgwgelir.Rows[i].Cells[7].Value;
                  

                    decimal para =Convert.ToDecimal(dgwgelir.Rows[i].Cells[6].Value);


                    e.Graphics.DrawString(dgwgelir.Rows[i].Cells[0].Value + " ", Govde, sb, 30, 190 + (i * 30));
                    e.Graphics.DrawString(dgwgelir.Rows[i].Cells[1].Value + " ", Govde, sb, 80, 190 + (i * 30));
                    e.Graphics.DrawString(dgwgelir.Rows[i].Cells[3].Value + " ", Govde, sb, 250, 190 + (i * 30));
                    e.Graphics.DrawString(dgwgelir.Rows[i].Cells[4].Value + " ", Govde, sb, 440, 190 + (i * 30));
                 e.Graphics.DrawString(para.ToString("c"), Govde, sb, 550, 190 + (i * 30));
                    e.Graphics.DrawString(date.ToShortDateString(), Govde, sb, 700, 190 + (i * 30));

                    toplamPara =toplamPara+ para ;


                }
                e.Graphics.DrawString("---------------------------------------------------------------------------------------------", baslik, sb, 200, dgwgelir.Rows.Count * 30);
                e.Graphics.DrawString("Toplam Tutar : " + toplamPara.ToString("c"), baslik, sb, 500,(dgwgelir.Rows.Count * 30) + 230);


            }











        }
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            ppdSatis.ShowDialog();

        }
        private void ppdSatis_Load(object sender, EventArgs e)
        {

        }
    }
}
