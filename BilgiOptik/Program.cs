using BilgiOptik.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOptik
{
    static class Program
    {
        public static Marka marka;
        public static Kategori kategori;
        public static Kullanici kullanici;
        public static Urun urun;
        public static Urun stokUrun;
        public static Musteri musteri;
        public static bool urunEklicenMi;
        public static bool kategoriEklicenMi;
        public static bool markaEklicenMi;
        public static Kullanici k;
        public static Musteri goz;
        public static int id;
        public static int SatisGozArasiID;
        public static bool ajanda = false, notDefteri = false;

        public static Satis GelenSatis { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBaslangicEkrani());
        }
    }
}
