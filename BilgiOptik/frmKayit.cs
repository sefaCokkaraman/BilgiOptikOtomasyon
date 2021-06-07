using BilgiOptik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOptik
{
    public partial class frmKayit : Form
    {
        BilgiOptikContext db = new BilgiOptikContext();
        Kullanici k = new Kullanici();
        Musteri m = new Musteri();
        Tedarikci t = new Tedarikci();

        string hsifre, hkullaniciAdi, mail, sifre, mesaj;
        public static string to;

     
        BilgiOptikFirma bof = new BilgiOptikFirma();


        public frmKayit()
        {
            InitializeComponent();
        }

        private void frmKayit_Load(object sender, EventArgs e)
        {
            bof = db.BilgiOptikFirma.FirstOrDefault();
            txtVergiNo.Visible = false;
            if (Program.k.yetkiID == 2)
            {
                rbMusteri.Checked = true;
                rbMusteri.Visible = false;
                rbPersonel.Visible = false;
                rbTedarikçi.Visible = false;
            }
            else
            {
                rbMusteri.Visible = true;
                rbMusteri.Checked = false;
            }
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

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.Anasayfa.Show();
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

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.ayarlar.Show();
            this.Hide();
        }

        //ÇALIŞAN
        private void btnMKayit_Click(object sender, EventArgs e)
        {

            //MUSTERİ
            if (rbMusteri.Checked == true && rbPersonel.Checked == false && rbTedarikçi.Checked == false)
            {
                m.kullaniciID = Program.k.kullaniciID;
                m.adi = txtAd.Text;
                m.soyadi = txtSoyad.Text;
                m.eposta = txtEposta.Text;
                m.telefon = mtbTelefon.Text;
                m.TCKimlikNo = txtTCKimlik.Text;
                m.adres = rtbAdres.Text;
                db.Musteri.Add(m);
                db.SaveChanges();
                MessageBox.Show("Kayıt Edildi");
            }

            //PERSONEL
            else if (rbPersonel.Checked == true && rbMusteri.Checked == false && rbTedarikçi.Checked == false)
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

            //TEDARİKÇİ
            else if (rbTedarikçi.Checked == true && rbMusteri.Checked == false && rbPersonel.Checked == false)
            {
                t.kullaniciID = Program.k.kullaniciID;                
                t.tedarikciAdi = txtAd.Text;               
                t.firmaAdi = txtSoyad.Text;
                t.eposta = txtEposta.Text;
                t.telefon = mtbTelefon.Text;              
                t.faks = Convert.ToInt32(txtTCKimlik.Text);
                t.tedarikciVergiNo = txtVergiNo.Text;
                t.adres = rtbAdres.Text;
                t.durum = true;
                db.Tedarikci.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kayıt Edildi");
            }
            else
            {
                MessageBox.Show("Bir kayıt türü seçiniz");
            }

        }

        private void rbMusteri_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMusteri.Checked == true)
            {
                lblAd.Visible = lblSoyad.Visible = lblTCKimlikNo.Visible = true;
                lblTedarikciAdSoyad.Visible = lblFaks.Visible = lblFirmaAd.Visible = lblVergiNo.Visible = txtVergiNo.Visible = false;
                btnMKayit.Enabled = true;
            }
        }

        private void rbPersonel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPersonel.Checked == true)
            {
                lblAd.Visible = lblSoyad.Visible = lblTCKimlikNo.Visible = true;
                lblTedarikciAdSoyad.Visible = lblFaks.Visible = lblFirmaAd.Visible = lblVergiNo.Visible = txtVergiNo.Visible = false;
                btnMKayit.Enabled = true;
            }
        }

        private void rbTedarikçi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTedarikçi.Checked == true)
            {
                lblAd.Visible = lblSoyad.Visible = lblTCKimlikNo.Visible = false;
                lblTedarikciAdSoyad.Visible = lblFaks.Visible = lblFirmaAd.Visible = lblVergiNo.Visible = txtVergiNo.Visible = true;
                btnMKayit.Enabled = true;
            }
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

        private void btnProfil_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.profilbilgi.Show();
            this.Hide();
            pnlMenu.Height = 75;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            formlarArasıGecis.giris.Show();
            pnlMenu.Height = 75;
            pnlKategori.Width = 130;
            this.Hide();
        }
    }
}