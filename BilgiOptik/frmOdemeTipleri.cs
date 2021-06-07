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
    public partial class frmOdemeTipleri : Form
    {

        //Dictionary<int, string> dicOdemeTurleri = new Dictionary<int, string>();
        public frmOdemeTipleri()
        {
            InitializeComponent();
        }
        BilgiOptikContext db = new BilgiOptikContext();

        private void frmOdemeTipleri_Load(object sender, EventArgs e)
        {
        
            //foreach (var item in db.OdemeTur)
            //{
            //    dicOdemeTurleri.Add(item.OdemeTurID, Text=item.adi);
            //}
            Listele();
        }
        private void Listele()
        {
            lstboxOdemeTipleri.DataSource = db.OdemeTur.Where(x=>x.durum==true).ToList();
            lstboxOdemeTipleri.ValueMember = "odemeTurID";
            lstboxOdemeTipleri.DisplayMember = "adi";

          
        }

        private void lstboxOdemeTipleri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var s = lstboxOdemeTipleri.SelectedValue;

            Program.odemeTur = db.OdemeTur.Find(s);
            Program.odemeTuruEklicenMi = false;
            formlarArasıGecis.odemeTuruİslemleri.ShowDialog();

            Listele();

        }

        private void btnBas_Click(object sender, EventArgs e)
        {
            Program.odemeTuruEklicenMi = true;
            formlarArasıGecis.odemeTuruİslemleri.ShowDialog();
            Listele();


        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Silmek istediğinizden Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (dialog == DialogResult.Yes)
            {
                var d = lstboxOdemeTipleri.SelectedValue;

                var s = db.OdemeTur.Find(d);
                s.durum = false;
                db.SaveChanges();
                Listele();







            }


        }
    }
}
