using BilgiOptik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOptik
{
    public partial class frmUrunler : Form
    {

        public frmUrunler()
        {
            InitializeComponent();
        }

        BilgiOptikContext db = new BilgiOptikContext();

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




        private void frmUrunler_Load(object sender, EventArgs e)
        {
            if (Program.k.yetkiID==2)
            {
                btnUrunEkle.Visible = false;
                btnKategoriEkle.Visible = false;
                btnGelir.Visible = false;
                btnGuncelle.Visible = false;
                btnKategoriEkle.Visible = false;
                btnStokEkle.Visible = false;
                btnMarkaEkle.Visible = false;
                btnSil.Visible = false;


                cmsUrunlerGrid.Enabled = false;


                


            }


            UrunGridGoster();

            cmbListele.Items.Add("Model Numarası");
            cmbListele.Items.Add("Urun Adi");
            cmbListele.Items.Add("Kategori");

            cmbListele.SelectedItem = cmbListele.Items[0];



        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {

            UrunGridGoster();
        }
        private void cmbListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtArama_TextChanged(sender, e);

        }
        #region Urun Gosterme İslemleri



        public object UrunGoster()
        {
            var sorgu = db.Urun.Where(x => x.durum == true).Select(x => new { x.urunID, x.modelNumarasi, x.urunAdi, x.aciklama, x.Kategori.kategoriAdi, x.urunEkartmani, x.stokMiktari }).ToList();
            return sorgu;

        }
        private object UrunGosterModelNo(string key)
        {
            var sorgu = db.Urun.Where(x => x.durum == true & x.modelNumarasi.Contains(key)).Select(x => new { x.urunID, x.modelNumarasi, x.urunAdi, x.aciklama, x.Kategori.kategoriAdi, x.urunEkartmani, x.stokMiktari }).ToList();




            return sorgu;
        }
        private object UrunGosterUrunAdi(string key)
        {
            var sorgu = db.Urun.Where(x => x.durum == true & x.urunAdi.Contains(key)).Select(x => new { x.urunID, x.modelNumarasi, x.urunAdi, x.aciklama, x.Kategori.kategoriAdi, x.urunEkartmani, x.stokMiktari }).ToList();
            return sorgu;
        }
        private object UrunGosterKategoriAdi(string key)
        {
            var sorgu = db.Urun.Where(x => x.durum == true && x.Kategori.kategoriAdi.Contains(key)).Select(x => new { x.urunID, x.modelNumarasi, x.urunAdi, x.aciklama, x.Kategori.kategoriAdi, x.urunEkartmani, x.stokMiktari }).ToList();
            return sorgu;
        }

        private void UrunGridGoster()
        {
            if (txtArama.Text == null)
                dgwUrunler.DataSource = UrunGoster();
            else
            {
                if (cmbListele.SelectedIndex == 0)
                {

                    dgwUrunler.DataSource = UrunGosterModelNo(txtArama.Text);

                }
                else if (cmbListele.SelectedIndex == 1)
                {

                    dgwUrunler.DataSource = UrunGosterUrunAdi(txtArama.Text);
                }
                else if (cmbListele.SelectedIndex == 2)
                {
                    dgwUrunler.DataSource = UrunGosterKategoriAdi(txtArama.Text);
                }
            }

        }
        private void dgwUrunler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Program.k.yetkiID!=2)
            {
                UrunGuncelle();

            } 

        }
        #endregion
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle();
            UrunGridGoster();
        }

        private void UrunEkle()
        {
            Program.urunEklicenMi = true;

            FormAcma.urunİslemleri.ShowDialog();


        }



        private void UrunGuncelle()
        {
            Program.urunEklicenMi = false;
            var d = dgwUrunler.CurrentRow.Cells[0].Value;
            Program.urun = db.Urun.Find(d);


            //dgwUrunler.DataSource = Program.u;


            FormAcma.urunİslemleri.ShowDialog();
            UrunGridGoster();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            UrunSil();

        }

        private void UrunSil()
        {
            DialogResult dialog = MessageBox.Show("Silmek isteğinizden emin misiniz ?", "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                var d = dgwUrunler.CurrentRow.Cells[0].Value;
                var silincekUrun = db.Urun.Find(d);

                silincekUrun.durum = false;

                db.SaveChanges();
                UrunGridGoster();
                MessageBox.Show("Ürün Silinmiştir");

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UrunGuncelle();

        }

        private void cmsEkle_Click(object sender, EventArgs e)
        {
            UrunEkle();

        }

        private void cmsSil_Click(object sender, EventArgs e)
        {
            UrunSil();
        }

        private void cmsDuzenle_Click(object sender, EventArgs e)
        {
            UrunGuncelle();
        }


        private void dgwUrunler_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.dgwUrunler.ClearSelection();
                    this.dgwUrunler.Rows[rowSelected].Selected = true;
                    Program.stokUrun = db.Urun.Find(dgwUrunler.CurrentRow.Cells[0].Value);
                }

            }
            

        }

        private void btnGelir_Click(object sender, EventArgs e)
        {
            FormAcma.GelirGider.Show();
            this.Hide();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            FormAcma.kategori.ShowDialog();



        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {


            FormAcma.marka.ShowDialog();


        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {

            if (Program.stokUrun != null)
            {

                FormAcma.FormGoster(new frmStokEkle());

            }
            else
            {
                MessageBox.Show("Lütfen bi ürün seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }



}
