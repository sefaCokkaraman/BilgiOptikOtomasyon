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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        BilgiOptikContext db = new BilgiOptikContext();
     
        private void frmKategori_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void Listele()
        {
            lstboxKategoriler.DataSource = db.Kategori.Where(x=>x.durum==true).Select(x => new { x.kategoriAdi, x.kategoriID }).ToList();
            lstboxKategoriler.DisplayMember = "kategoriAdi";
            lstboxKategoriler.ValueMember = "kategoriID";
        }

        private void btnBas_Click(object sender, EventArgs e)
        {
            Program.kategoriEklicenMi = true;
            FormAcma.kategoriIslemleri.ShowDialog();
            Listele();
           
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstboxKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult  dialog =  MessageBox.Show("Silmek İstedğinizden Emin misiniz ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialog==DialogResult.Yes)
            {
                var d = lstboxKategoriler.SelectedValue;

                var sorgu = db.Kategori.Find(d);
                sorgu.durum = false;
                db.SaveChanges();
                Listele();

            }



        }

        private void lstboxKategoriler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var sorg = lstboxKategoriler.SelectedValue;

            Program.kategori = db.Kategori.Find(sorg);
            Program.kategoriEklicenMi = false;
            FormAcma.kategoriIslemleri.ShowDialog();
         
            Listele();


        }
    }
}
