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
        public static frmAnasayfa Anasayfa = new frmAnasayfa();
        public static frmKayit kayit = new frmKayit();
        public static BilgiOptik giris = new BilgiOptik();
        public static frmAyarlar ayarlar = new frmAyarlar();
        public static frmBilgiler bilgiler = new frmBilgiler();
        public static frmOdemeler odemeler = new frmOdemeler();
        public static frmSatinAl satinAl = new frmSatinAl();
        public static frmUrunler urunler = new frmUrunler();
        public static frmGozNumara gozNumara = new frmGozNumara();
#pragma warning disable CS0246 // The type or namespace name 'frmYeniKayit' could not be found (are you missing a using directive or an assembly reference?)
        public static frmYeniKayit yeniKayit = new frmYeniKayit();
#pragma warning restore CS0246 // The type or namespace name 'frmYeniKayit' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'frmUrunİslemleri' could not be found (are you missing a using directive or an assembly reference?)
        public static frmUrunİslemleri urunİslemleri = new frmUrunİslemleri();
#pragma warning restore CS0246 // The type or namespace name 'frmUrunİslemleri' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'frmGelirGider' could not be found (are you missing a using directive or an assembly reference?)
        public static frmGelirGider GelirGider = new frmGelirGider();
#pragma warning restore CS0246 // The type or namespace name 'frmGelirGider' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'frmKategori' could not be found (are you missing a using directive or an assembly reference?)
        public static frmKategori kategori = new frmKategori();
#pragma warning restore CS0246 // The type or namespace name 'frmKategori' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'frmKategoriIslemleri' could not be found (are you missing a using directive or an assembly reference?)
        public static frmKategoriIslemleri kategoriIslemleri = new frmKategoriIslemleri();
#pragma warning restore CS0246 // The type or namespace name 'frmKategoriIslemleri' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'frmMarka' could not be found (are you missing a using directive or an assembly reference?)
        public static frmMarka marka = new frmMarka();
#pragma warning restore CS0246 // The type or namespace name 'frmMarka' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'frmMarkaIslemleri' could not be found (are you missing a using directive or an assembly reference?)
        public static frmMarkaIslemleri markaIslemleri = new frmMarkaIslemleri();
#pragma warning restore CS0246 // The type or namespace name 'frmMarkaIslemleri' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'frmStokEkle' could not be found (are you missing a using directive or an assembly reference?)
        public static frmStokEkle stokEkle = new frmStokEkle();
#pragma warning restore CS0246 // The type or namespace name 'frmStokEkle' could not be found (are you missing a using directive or an assembly reference?)

        public static void FormGoster(Form form)
        {
            form.Show();

        }
    }
}
