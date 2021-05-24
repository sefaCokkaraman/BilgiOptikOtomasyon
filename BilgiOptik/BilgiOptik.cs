using BilgiOptik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOptik
{
    public partial class BilgiOptik : Form
    {

        BilgiOptikContext db = new BilgiOptikContext();

        public BilgiOptik()
        {
            InitializeComponent();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici, sifre;
            kullanici = txtKullaniciAdi.Text;
            sifre = txtSifre.Text;
            Kullanici k = db.Kullanici.Where(d => d.kullaniciAdi == kullanici && d.sifre == sifre).SingleOrDefault();

            if (k == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (k != null)
            {
                Program.k = k;
                formlarArasıGecis.Anasayfa.Show();
                this.Hide();
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }
        }

        private void lblKayit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakında Gelicek");
        }

        private void btnSifreKapali_Click(object sender, EventArgs e)
        {
            if (txtSifre.PasswordChar == '\0')
            {
                btnSifreAcık.BringToFront();
                txtSifre.PasswordChar = ('*');
            }
        }

        private void btnSifreAcık_Click(object sender, EventArgs e)
        {
            if (txtSifre.PasswordChar == '*')
            {
                btnSifreKapali.BringToFront();
                txtSifre.PasswordChar = ('\0');
            }
        }

        private void lblSifremiUnuttum_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.sifremiUnuttum.Show();
            this.Hide();
        }
    }
}
