namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            Ajanda = new HashSet<Ajanda>();
            Musteri = new HashSet<Musteri>();
            NotDefteri = new HashSet<NotDefteri>();
            Satis = new HashSet<Satis>();
        }

        public int kullaniciID { get; set; }

        public int yetkiID { get; set; }

        [Required]
        [StringLength(50)]
        public string adi { get; set; }

        [Required]
        [StringLength(50)]
        public string soyadi { get; set; }

        [StringLength(100)]
        public string eposta { get; set; }

        [Required]
        [StringLength(11)]
        public string TCKimlikNo { get; set; }

        [Required]
        [StringLength(20)]
        public string telefon { get; set; }

        [Required]
        public string adres { get; set; }

        [Required]
        [StringLength(50)]
        public string kullaniciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string sifre { get; set; }

        [Column(TypeName = "money")]
        public decimal? maas { get; set; }

        [StringLength(200)]
        public string profil { get; set; }

        public bool? durum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ajanda> Ajanda { get; set; }

        public virtual Yetki Yetki { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Musteri> Musteri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotDefteri> NotDefteri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
