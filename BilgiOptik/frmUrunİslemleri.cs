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
namespace BilgiOptik
{
    public partial class frmUrunİslemleri : Form
    {
        public frmUrunİslemleri()
        {
            InitializeComponent();
        }
        BilgiOptikContext db = new BilgiOptikContext();
        //DoldurmaIslemleri doldurma = new DoldurmaIslemleri();
        Urun gelenUrun = Program.urun;
        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (Program.urunEklicenMi == true)
            {
                UrunEkle();

            }// db.Urun.Add(sorgu);

            else
            {
                UrunGuncelle();
            }
            this.Close();

        }

        private void UrunEkle()
        {
            Urun urunEkle = new Urun
            {
                urunAdi = txtUrunAdi.Text,
                aciklama = txtAciklama.Text,
                kategoriID = Convert.ToInt32(cmbKategori.SelectedValue),
                markaID = Convert.ToInt32(cmbMarka.SelectedValue),
                modelNumarasi = txtModelNumarasi.Text,
                tedarikciID = Convert.ToInt32(cmbTedarikci.SelectedValue),
                urunEkartmani = txtUrunEkartmani.Text,
                stokMiktari = Convert.ToInt32(numStokMiktari.Value),
                alisFiyat=numAlisFiyat.Value,
                satisFiyat=numSatisFiyat.Value,durum=true

            }; 
          db.Urun.Add(urunEkle);
            db.SaveChanges();
            Urun urun2 = db.Urun.Where(x => x.modelNumarasi == urunEkle.modelNumarasi).SingleOrDefault();


            TedarikciGider tedarikciGider = new TedarikciGider{ 
                tedarikciID = Convert.ToInt32(urunEkle.tedarikciID),
                urunID = urun2.urunID, miktar =(int)urunEkle.stokMiktari,
                birimFiyat = urunEkle.alisFiyat,
                toplamTutar = (int)urunEkle.alisFiyat * (int)urunEkle.stokMiktari,
                eklenmeTarihi = DateTime.Now,
                odemeTurID=1
            };
            db.TedarikciGider.Add(tedarikciGider);
            db.SaveChanges();

            MessageBox.Show("Ürün Eklendi", "Ürün Ekleme Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UrunGuncelle()
        {
            Urun sorgu = db.Urun.Where(x => x.urunID == gelenUrun.urunID).SingleOrDefault();
         

            sorgu.urunID = gelenUrun.urunID;
            sorgu.urunAdi = txtUrunAdi.Text;
            sorgu.aciklama = txtAciklama.Text;
            sorgu.kategoriID = Convert.ToInt32(cmbKategori.SelectedValue);
            sorgu.markaID = Convert.ToInt32(cmbMarka.SelectedValue);
            sorgu.modelNumarasi = txtModelNumarasi.Text;
            sorgu.tedarikciID = Convert.ToInt32(cmbTedarikci.SelectedValue);
            sorgu.urunEkartmani = txtUrunEkartmani.Text;
            sorgu.stokMiktari = Convert.ToInt32(numStokMiktari.Value);
            sorgu.satisFiyat= Convert.ToDecimal(numSatisFiyat.Value);
            sorgu.alisFiyat = Convert.ToDecimal(numAlisFiyat.Value);
            


            //int id = sorgu.urunID;
            //sorgu = gelenUrun;
            //sorgu.urunID = id;
            //db.Entry(sorgu).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi", "Ürün Güncelleme Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmUrunİslemleri_Load(object sender, EventArgs e)
        {
            gelenUrun = Program.urun;

            ComboBoxlariDoldur();

            if (Program.urunEklicenMi == false && gelenUrun != null)
            {
                txtAciklama.Text = gelenUrun.aciklama;
                txtModelNumarasi.Text = gelenUrun.modelNumarasi;
                txtUrunAdi.Text = gelenUrun.urunAdi;
                txtUrunEkartmani.Text = gelenUrun.urunEkartmani;
                cmbKategori.SelectedValue = gelenUrun.kategoriID;
                cmbMarka.SelectedValue = gelenUrun.markaID;
                cmbTedarikci.SelectedValue = gelenUrun.tedarikciID;
                numStokMiktari.Value = gelenUrun.stokMiktari.Value;
                numAlisFiyat.Value = gelenUrun.alisFiyat;
                numSatisFiyat.Value = gelenUrun.satisFiyat;


                btnEkle.Text = "Güncelle";
            }
            else if (Program.urunEklicenMi == true)
            {
                txtAciklama.Text = "";
                txtModelNumarasi.Text = "";
                txtUrunAdi.Text = "";
                txtUrunEkartmani.Text = "";
                cmbKategori.SelectedValue = 1;
                cmbMarka.SelectedValue = 1;
                cmbTedarikci.SelectedValue = 1;
                numStokMiktari.Value = 0;
                numAlisFiyat.Value = 0;
                numSatisFiyat.Value = 0;
            }
        }

        private void ComboBoxlariDoldur()
        {
            cmbKategori.DataSource = db.Kategori.ToList();
            cmbKategori.DisplayMember = "kategoriAdi";
            cmbKategori.ValueMember = "kategoriID";
            cmbMarka.DataSource = db.Marka.ToList();
            cmbMarka.DisplayMember = "adi";
            cmbMarka.ValueMember = "markaID";
            cmbTedarikci.DataSource = db.Tedarikci.ToList();
            cmbTedarikci.DisplayMember = "firmaAdi";
            cmbTedarikci.ValueMember = "tedarikciID";
        }

        private void frmUrunİslemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnEkle.Text = "Ekle";

        }
    }
}
