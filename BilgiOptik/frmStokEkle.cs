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
    public partial class frmStokEkle : Form
    {
        Urun ur;
        public frmStokEkle()
        {
            InitializeComponent();
        }
        BilgiOptikContext db = new BilgiOptikContext();
        private void btnStokEkle_Click(object sender, EventArgs e)
        {


            TedarikciGider tedarikciGider = new TedarikciGider
            {
                urunID = ur.urunID,
                birimFiyat = numAlisFiyat.Value,
                miktar = Convert.ToInt32(numStokMiktari.Value),
                odemeTurID = cmbOdemeTuru.SelectedIndex,
                eklenmeTarihi = DateTime.Now,
                tedarikciID=ur.tedarikciID,
                toplamTutar=numStokMiktari.Value*numAlisFiyat.Value
            };

            db.TedarikciGider.Add(tedarikciGider);

            var sorgu = db.Urun.Find(ur.urunID);
            sorgu.stokMiktari = sorgu.stokMiktari + (int)numStokMiktari.Value;
            sorgu.alisFiyat = numAlisFiyat.Value;
            sorgu.satisFiyat = numSatisFiyat.Value;

            db.SaveChanges();
            MessageBox.Show("Stok Eklenmiştir","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            this.Close();


        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStokEkle_Load(object sender, EventArgs e)
        {

            
            ur = Program.stokUrun;
            numAlisFiyat.Value =Convert.ToInt32(ur.alisFiyat);
            numSatisFiyat.Value = Convert.ToInt32( ur.satisFiyat);
            txtUrunAd.Text = Program.stokUrun.urunAdi;
            cmbOdemeTuru.DataSource = db.OdemeTur.ToList();
            cmbOdemeTuru.DisplayMember = "Adi";
            cmbOdemeTuru.ValueMember = "OdemeTurID";
            lblStokMiktar.Text = ur.stokMiktari.ToString();

        }
    }
}
