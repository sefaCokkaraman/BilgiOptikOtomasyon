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
    public partial class frmOdemeTuruİslemleri : Form
    {
        public frmOdemeTuruİslemleri()
        {
            InitializeComponent();
        }
        private void frmOdemeTuruİslemleri_Load(object sender, EventArgs e)
        {

            if (Program.odemeTuruEklicenMi == false)
            {
                btnEkle.Text = "Güncelle";
                txtOdemeTuruAdi.Text = Program.odemeTur.adi;
            }
            else
            {
                txtOdemeTuruAdi.Clear();
            }
        }

        private void Guncelle()
        {
            using (BilgiOptikContext db = new BilgiOptikContext())
            {


                var s = db.OdemeTur.Find(Program.odemeTur.OdemeTurID);
                s.adi = txtOdemeTuruAdi.Text;
                db.SaveChanges();

            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "Güncelle")
            {
                if (Program.odemeTuruEklicenMi == false)
                {
                    DialogResult dialog = MessageBox.Show("Güncellemek istediğinizden Emin misiniz ?", "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        Guncelle();
                        MessageBox.Show("Güncellenmiştir", "Marka Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    this.Close();
                }
            }
            else
            {
                Ekle();
            }
        }
        private void Ekle()
        {
            using (BilgiOptikContext db= new BilgiOptikContext())
            {
                OdemeTur odemeTur = new OdemeTur();
                odemeTur.adi = txtOdemeTuruAdi.Text;
               
                var s = db.OdemeTur.Where(x => x.adi == odemeTur.adi).FirstOrDefault();
                if (s!=null)
                {
                    s.durum =true;
                }
                else
                {
                    odemeTur.durum = true;
                    db.OdemeTur.Add(odemeTur);
                }
                db.SaveChanges();
                MessageBox.Show("Eklenmiştir", "Marka Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOdemeTuruİslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.odemeTuruEklicenMi= true;
            btnEkle.Text = "Ekle";
        }
    }
}
