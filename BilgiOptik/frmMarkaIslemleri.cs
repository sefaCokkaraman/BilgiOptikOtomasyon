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
    public partial class frmMarkaIslemleri : Form
    {
        public frmMarkaIslemleri()
        {
            InitializeComponent();
        }


        private void frmMarkaIslemleri_Load(object sender, EventArgs e)
        {

            if (Program.markaEklicenMi == false)
            {
                btnEkle.Text = "Güncelle";
                txtMarkaAdi.Text = Program.marka.adi;



            }

            else
            {
                txtMarkaAdi.Clear();
            }


            //Güncelle işlemi eklencek
            //Sil burada eklenmicek





        }

        private void Guncelle()
        {
            using (BilgiOptikContext db = new BilgiOptikContext())
            {
                var sorgu = db.Marka.Find(Program.marka.markaID);
                sorgu.adi = txtMarkaAdi.Text;
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
                if (Program.markaEklicenMi == false)
                {


                    DialogResult dialog = MessageBox.Show("Güncellemek isteğinizden emin misiniz ?", "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        Guncelle();
                        MessageBox.Show("Güncellenmiştir", "Marka Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        this.Close();


                    }
                    else
                    {
                       
                        this.Close();

                    }

                }
            }




            else
            {
                Ekle();
               
            }


        }

        private void Ekle()
        {



            using (BilgiOptikContext db = new BilgiOptikContext())
            {
                Marka marka = new Marka();
                marka.adi = txtMarkaAdi.Text;
                var sorgu = db.Marka.Where(x => x.adi == marka.adi).SingleOrDefault();

                if (sorgu != null)
                {

                    sorgu.durum = true;
                }

                else
                {
                    marka.durum = true;
                    db.Marka.Add(marka);

                }
                db.SaveChanges();
                MessageBox.Show("Eklenmiştir", "Marka Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }










        }

        private void frmMarkaIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.markaEklicenMi = true;
            btnEkle.Text = "Ekle";
        }

        private void btnIptal_Click_1(object sender, EventArgs e)
        {

        }
    }
}
