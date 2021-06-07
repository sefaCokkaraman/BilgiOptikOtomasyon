namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Musteri")]
    public partial class Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteri()
        {
            gozDaimi = new HashSet<gozDaimi>();
            gozUzak = new HashSet<gozUzak>();
            gozYakin = new HashSet<gozYakin>();
            Satis = new HashSet<Satis>();
            Sikayet = new HashSet<Sikayet>();
        }

        public int musteriID { get; set; }

        public int kullaniciID { get; set; }

        [Required]
        [StringLength(50)]
        public string adi { get; set; }

        [Required]
        [StringLength(50)]
        public string soyadi { get; set; }

        [Required]
        [StringLength(100)]
        public string eposta { get; set; }

        [Required]
        [StringLength(20)]
        public string telefon { get; set; }

        [Required]
        [StringLength(11)]
        public string TCKimlikNo { get; set; }

        [StringLength(500)]
        public string adres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gozDaimi> gozDaimi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gozUzak> gozUzak { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gozYakin> gozYakin { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sikayet> Sikayet { get; set; }
    }
}
