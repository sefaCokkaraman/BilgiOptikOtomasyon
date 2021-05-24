namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Satis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Satis()
        {
            Sikayet = new HashSet<Sikayet>();
            UrunDetay = new HashSet<UrunDetay>();
        }

        public int satisID { get; set; }

        public int musteriID { get; set; }

        public int kullaniciID { get; set; }

        public int? urunID { get; set; }

        [Column(TypeName = "money")]
        public decimal? toplamTutar { get; set; }

        public int? odemeTurID { get; set; }

        public DateTime? tarih { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Musteri Musteri { get; set; }

        public virtual OdemeTur OdemeTur { get; set; }

        public virtual Urun Urun { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sikayet> Sikayet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunDetay> UrunDetay { get; set; }
    }
}
