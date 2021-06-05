namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Urun")]
    public partial class Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun()
        {
            Satis = new HashSet<Satis>();
            TedarikciGider = new HashSet<TedarikciGider>();
            UrunDetay = new HashSet<UrunDetay>();
        }

        public int urunID { get; set; }

        public int kategoriID { get; set; }

        public int? tedarikciID { get; set; }

        [StringLength(500)]
        public string urunAdi { get; set; }

        public string aciklama { get; set; }

        public int markaID { get; set; }

        public int? stokMiktari { get; set; }

        [StringLength(50)]
        public string modelNumarasi { get; set; }

        [StringLength(11)]
        public string urunEkartmani { get; set; }

        [Column(TypeName = "money")]
        public decimal alisFiyat { get; set; }

        [Column(TypeName = "money")]
        public decimal satisFiyat { get; set; }

        public bool? durum { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual Marka Marka { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }

        public virtual Tedarikci Tedarikci { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TedarikciGider> TedarikciGider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunDetay> UrunDetay { get; set; }
    }
}
