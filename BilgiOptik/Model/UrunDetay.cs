namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UrunDetay")]
    public partial class UrunDetay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UrunDetay()
        {
            UrunOzellik = new HashSet<UrunOzellik>();
        }

        public int urunDetayID { get; set; }

        public int urunID { get; set; }

        public int? satisID { get; set; }

        [Column(TypeName = "money")]
        public decimal? tutar { get; set; }

        public int? miktar { get; set; }

        public virtual Satis Satis { get; set; }

        public virtual Urun Urun { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunOzellik> UrunOzellik { get; set; }
    }
}
