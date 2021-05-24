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
    public partial class frmProfil : Form
    {
        public frmProfil()
        {
            InitializeComponent();
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {
            lblAnasayfa.Text = Program.k.kullaniciAdi;

            textBox1.Text = Program.k.adi;
            textBox2.Text = Program.k.soyadi;
            textBox3.Text = Program.k.TCKimlikNo;
            textBox4.Text = Program.k.telefon.ToString();
            textBox5.Text = Program.k.eposta;
            textBox6.Text = Program.k.Yetki.adi;
            textBox7.Text = Program.k.maas.ToString();
            textBox8.Text = Program.k.adres;
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.Anasayfa.Show();
            this.Hide();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.kayit.Show();
            this.Hide();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.urunler.Show();
            this.Hide();
        }

        private void btnBilgiler_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.bilgiler.Show();
            this.Hide();
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.odemeler.Show();
            this.Hide();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.satinAl.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlKategori.Width != btnMenu.Width)
            {
                pnlKategori.Width = btnMenu.Width;
            }
            else
            {
                pnlKategori.Width = btnAnasayfa.Width;
            }
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Height == 75)
            {
                pnlMenu.Height = 243;
            }
            else
            {
                pnlMenu.Height = 75;
            }
        }
    }
}
