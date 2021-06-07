using BilgiOptik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOptik
{
    public partial class frmGirisKayit : Form
    {
        string hsifre, hkullaniciAdi, mail, sifre, mesaj;
        public static string to;

        BilgiOptikContext db = new BilgiOptikContext();
        Kullanici k = new Kullanici();
        BilgiOptikFirma bof = new BilgiOptikFirma();

        public frmGirisKayit()
        {
            InitializeComponent();
        }

        private void frmGirisKayit_Load(object sender, EventArgs e)
        {
            bof = db.BilgiOptikFirma.FirstOrDefault();
        }

        public void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEposta.Text == "" || mtbTelefon.Text == "(   )    -" || txtTCKimlik.Text == "" || rtbAdres.Text == "")
            {
                MessageBox.Show("Boş Geçilemez!");
            }
            else
            {
                k.yetkiID = 2;
                k.adi = txtAd.Text;
                k.soyadi = txtSoyad.Text;
                k.eposta = txtEposta.Text;
                k.telefon = mtbTelefon.Text;
                k.TCKimlikNo = txtTCKimlik.Text;
                k.adres = rtbAdres.Text;
                k.durum = true;
                Random rand = new Random();
                hkullaniciAdi = (rand.Next(999999)).ToString();
                hsifre = (rand.Next(999999)).ToString();
                k.kullaniciAdi = hkullaniciAdi;
                k.sifre = hsifre;
                MailMessage message = new MailMessage();
                to = (k.eposta).ToString();
                mail = bof.email;
                sifre = bof.sifre;
                mesaj = "Merhaba" + k.adi + " " + k.soyadi + "," + "\n \n Hesap Kullanıcı Adınız :" + hkullaniciAdi + "\n Hesap Şifreniz: " + hsifre;
                message.To.Add(to);
                message.From = new MailAddress(mail);
                message.Body = mesaj;
                message.Subject = "Bilgi Optik Kayıt Talebi";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(mail, sifre);
                smtp.Send(message);
                MessageBox.Show("Personel Kayıtı Başarıyla Gerçekleşmiştir.\nKullanıcı Adınız ve Şifreniz Mail Hesabınıza Yollanmıştır", "Personel Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Ad-Soyad: " + k.adi + " " + k.soyadi + "\nEposta: " + k.eposta + "\nTelefon: " + k.telefon + "\nT.C Kimlik No: " + k.TCKimlikNo
                + "\nAdres: " + k.adres);
                db.Kullanici.Add(k);
                db.SaveChanges();
            }
            textboxTemizleme();
        }

        private void textboxTemizleme()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {

                    ((TextBox)c).Text = "";
                   
                    
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = "";
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = "(   ) -";
                }
            }
        }
    }
}
