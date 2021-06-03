using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BilgiOptik.Model;

namespace BilgiOptik
{
    public partial class frmNotDefteri : Form
    {
        BilgiOptikContext db = new BilgiOptikContext();
        public frmNotDefteri()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            var liste = db.NotDefteri.Where(x => x.kullaniciID == Program.k.kullaniciID).ToList();
            lstGecmisNotlar.DataSource = liste;
            lstGecmisNotlar.ValueMember = "notDefteriID";
            lstGecmisNotlar.DisplayMember = "notu";
        }

        //private void frmNotDefteri_Load(object sender, EventArgs e)
        //{
        //    Listele();
        //}

        int id = 0;
        string baslik, aciklama;
        private void sorgu()
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

        private void Temizle()
        {
            txtBaslik.Clear();
            rtbMesaj.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            NotDefteri nd = new NotDefteri();

            if (txtBaslik.Text == "" && rtbMesaj.Text == "")
            {
                MessageBox.Show("Bilgileri Boş Bırakamazsınız");
            }
            else
            {
                kaydet.Title = "Kayıt Yeri Seçin"; // kaydet açıldığı zaman başlık kısmı textboxdan gelen değer olsun
                kaydet.Filter = "Metin Dosyası | *.txt"; //filtreleme yaptık. Sadece Metin Dosyalarını seçtik. Filter 2 tane parametre alıyor. Sol tarafta ne yazıcagı(Kayıt Turu) sag tarafta turu.
                kaydet.InitialDirectory = "D:\\Notlar"; //Başlangaçta nerden başlıyacağı
                kaydet.FileName = txtBaslik.Text;
                kaydet.ShowDialog();
                StreamWriter yaz = new StreamWriter(kaydet.FileName); //Akışı yazan komut (D:\\Notlar\\1.txt)
                yaz.WriteLine(rtbMesaj.Text); //satır olarak rtbMesaj dan gelen degerı yazdırsın
                yaz.Close(); //kaydetme islemini kapatsın
                nd.kullaniciID = Program.k.kullaniciID;
                nd.tarih = DateTime.Now;
                nd.baslik = txtBaslik.Text;
                nd.notu = rtbMesaj.Text;
                db.NotDefteri.Add(nd);
                db.SaveChanges();
                MessageBox.Show("Not Eklendi");
            }
            Temizle();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            id = (int)lstGecmisNotlar.SelectedValue;
            var sorgu = db.NotDefteri.Find(id);
            db.NotDefteri.Remove(sorgu);
            db.SaveChanges();
            MessageBox.Show("Not Silindi");
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            id = (int)lstGecmisNotlar.SelectedValue;
            var sorgu = db.NotDefteri.Find(id);

            sorgu.baslik = txtBaslik.Text;
            sorgu.notu = rtbMesaj.Text;
            db.SaveChanges();
            MessageBox.Show("Başarıyla Güncellendi");
            Listele();
        }
    }
}
