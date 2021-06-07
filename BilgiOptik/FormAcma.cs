using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOptik
{
    class FormAcma
    {
        public static frmNotDefteri notDefteri = new frmNotDefteri();
        public static frmAnasayfa Anasayfa = new frmAnasayfa();
        public static frmKayit kayit = new frmKayit();
        public static BilgiOptik giris = new BilgiOptik();
        public static frmAyarlar ayarlar = new frmAyarlar();
        public static frmBilgiler bilgiler = new frmBilgiler();
        public static frmOdemeler odemeler = new frmOdemeler();
        public static frmSatinAl satinAl = new frmSatinAl();
        public static frmUrunler urunler = new frmUrunler();
        public static frmGozNumara gozNumara = new frmGozNumara();
        public static frmUrunİslemleri urunİslemleri = new frmUrunİslemleri();
        public static frmGelirGider GelirGider = new frmGelirGider();
        public static frmKategori kategori = new frmKategori();
        public static frmKategoriIslemleri kategoriIslemleri = new frmKategoriIslemleri();
        public static frmMarka marka = new frmMarka();
        public static frmMarkaIslemleri markaIslemleri = new frmMarkaIslemleri();
        public static frmStokEkle stokEkle = new frmStokEkle();
        public static frmGirisKayit girisKayit = new frmGirisKayit();
        
        public static void FormGoster(Form form)
        {
            form.Show();

        }
    }
}
