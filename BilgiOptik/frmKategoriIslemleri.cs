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
    public partial class frmKategoriIslemleri : Form
    {
        public frmKategoriIslemleri()
        {
            InitializeComponent();
        }


        private void frmKategoriIslemleri_Load(object sender, EventArgs e)
        {

            if (Program.kategoriEklicenMi == false)
            {
                btnEkle.Text = "Güncelle";
                txtKategoriAdi.Text = Program.kategori.kategoriAdi;



            }
            else
            {
                txtKategoriAdi.Clear();
            }



            //Güncelle işlemi eklencek
            //Sil burada eklenmicek





        }

        private void Guncelle()
        {
            using (BilgiOptikContext db = new BilgiOptikContext())
            {
                var sorgu = db.Kategori.Find(Program.kategori.kategoriID);
                sorgu.kategoriAdi = txtKategoriAdi.Text;
                db.SaveChanges();


            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "Güncelle")
            {


                DialogResult dialog = MessageBox.Show("Güncellemek isteğinizden emin misiniz ?", "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                   
                        Guncelle();
                        MessageBox.Show("Güncellenmiştir", "Kategori Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                   
                }
                else
                {
                    this.Close();
                }

            }
            else
            {
                Ekle();
                this.Close();
              
            }


        }

        private void Ekle()
        {



            using (BilgiOptikContext db = new BilgiOptikContext())
            {
                Kategori kategori = new Kategori();
                kategori.kategoriAdi = txtKategoriAdi.Text;
                var sorgu = db.Kategori.Where(x => x.kategoriAdi == kategori.kategoriAdi).SingleOrDefault();

                if (sorgu != null)
                {

                    sorgu.durum = true;
                }

                else
                {
                    kategori.durum = true;
                    db.Kategori.Add(kategori);

                }
                db.SaveChanges();
                MessageBox.Show("Eklenmiştir", "Kategori Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }










        }

        private void frmKategoriIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.kategoriEklicenMi = true;
            btnEkle.Text = "Ekle";
        }
    }
}
