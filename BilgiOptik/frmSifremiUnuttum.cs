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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security;
using System.Net.Mail;
using System.Net.Configuration;
using System.Net;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;

namespace BilgiOptik
{
    public partial class frmSifremiUnuttum : Form
    {
        string guvenlikSifresi, kullanici;
        string bilgioptik = "Bilgi Optik";
        public static string to;

        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        BilgiOptikContext db = new BilgiOptikContext();
        Kullanici k = new Kullanici();
        BilgiOptikFirma bof = new BilgiOptikFirma();

        private void frmSifremiUnuttum_Load(object sender, EventArgs e)
        {
            bof = db.BilgiOptikFirma.FirstOrDefault();
        }

        private void giris()
        {
            formlarArasıGecis.giris.Show();
            this.Hide();
        }

        private void lblAktivasyonCikis_Click(object sender, EventArgs e)
        {
            giris();
        }

        private void lblSifreCikis_Click(object sender, EventArgs e)
        {
            giris();
        }

        private void lblKullaniciCikis_Click(object sender, EventArgs e)
        {
            giris();
        }

        public void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            kullanici = txtKadi.Text;
            Kullanici k = db.Kullanici.Where(d => d.kullaniciAdi == kullanici).SingleOrDefault();

            if (k != null)
            {
                pnlAktivasyonkodu.Visible = true;

                try
                {
                    string mail, sifre, mesaj;
                    Random rand = new Random();
                    guvenlikSifresi = (rand.Next(999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (k.eposta).ToString();
                    mail = bof.email;
                    sifre = bof.sifre;
                    mesaj = "Merhaba, \n \n" + bilgioptik + " hesap şifreni değiştirmek için " + guvenlikSifresi + " aktivasyon kodunu gir." +
                    "\n \nDaha önce de şifre değişikliği için talepte bulunduysan yalnızca en son gelen epostadaki kod geçerlidir." 
                    +  " \n \nBu siz değilseniz: \n \n" + bilgioptik + " Masaüstü hesabınıza başkası giriş yapmış olabilir. Hesabınızın güvenliği için parolanızı sıfırlamayı ve" +
                    " yöneticinizle iletişime geçmeyi unutmayın. \n \n" + "Saygılarımızla, \n \n" + bilgioptik + " Ekibi";
                    //mesaj = "Güvenlik kodu: " + güvenlikSifresi;
                    message.To.Add(to);
                    message.From = new MailAddress(mail);
                    message.Body = mesaj;
                    message.Subject = "Bilgi Optik Şifre Değiştirme Talebi";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(mail, sifre);

                    smtp.Send(message);
                    MessageBox.Show("Merhaba " + kullanici +" \nEposta adresine aktivasyon kodu gönderilmiştir");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (k == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAktivasyonKodGonder_Click(object sender, EventArgs e)
        {
            if(txtAktivasyonKodu.Text == guvenlikSifresi)
            {
                pnlAktivasyonkodu.Visible = false;
                pnlYeniSifre.Visible = true;
            }
            else
            {
                MessageBox.Show("Yanlış aktivasyon kodu");
            }
        }

        private void btnYeniSifre_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text==txtYeniSifreTekrar.Text)
            {
                //Kullanici k = db.Kullanici.Where(d => d.kullaniciAdi == kullanici).SingleOrDefault();

                string ySifre = txtYeniSifre.Text;
                var sifreyenileme = db.Kullanici.Where(w => w.kullaniciAdi == txtKadi.Text).SingleOrDefault();
                sifreyenileme.sifre = txtYeniSifre.Text;
                db.SaveChanges();
                MessageBox.Show("Şifreniz başarıyla değiştirilmiştir");
                MessageBox.Show("Program yeniden başlatılacaktır", "Yeniden Başlatma" ,MessageBoxButtons.OK, MessageBoxIcon.Information );
                //Close();
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor");
            }
        }

        //formlarArasıGecis.giris.Show();
        //this.Hide();
    }
}
