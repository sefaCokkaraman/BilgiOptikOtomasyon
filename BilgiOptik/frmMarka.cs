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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }

        BilgiOptikContext db = new BilgiOptikContext();
        
      
        private void frmMarka_Load_1(object sender, EventArgs e)
        { Listele();

        }

        private void Listele()
        {
            lstboxMarkalar.DataSource = db.Marka.Where(x => x.durum == true).Select(x => new { x.adi, x.markaID}).ToList();

            lstboxMarkalar.DisplayMember = "adi";

            lstboxMarkalar.ValueMember = "markaID";
        }

       
       

       

        private void lstboxMarkalar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var sorg = lstboxMarkalar.SelectedValue;

            Program.marka = db.Marka.Find(sorg);
            Program.markaEklicenMi = false;
            FormAcma.markaIslemleri.ShowDialog();

            Listele();

            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Program.markaEklicenMi = true;
            FormAcma.markaIslemleri.ShowDialog();
            Listele();


        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstboxMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
              DialogResult dialog = MessageBox.Show("Silmek İstedğinizden Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    var d = lstboxMarkalar.SelectedValue;

                    var sorgu = db.Marka.Find(d);
                    sorgu.durum = false;
                    db.SaveChanges();
                    Listele();

               


            }
        }
    }
}
