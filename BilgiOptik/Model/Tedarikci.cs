namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tedarikci")]
    public partial class Tedarikci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tedarikci()
        {
            TedarikciGider = new HashSet<TedarikciGider>();
            Urun = new HashSet<Urun>();
        }

        public int tedarikciID { get; set; }

        public int? kullaniciID { get; set; }

        [StringLength(100)]
        public string firmaAdi { get; set; }

        [StringLength(50)]
        public string tedarikciAdi { get; set; }

        [StringLength(50)]
        public string tedarikciVergiNo { get; set; }

        [StringLength(20)]
        public string telefon { get; set; }

        public int? faks { get; set; }

        [StringLength(100)]
        public string eposta { get; set; }

        public string adres { get; set; }

        public bool? durum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TedarikciGider> TedarikciGider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urun> Urun { get; set; }
    }
}
