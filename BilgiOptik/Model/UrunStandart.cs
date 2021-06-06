namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UrunStandart")]
    public partial class UrunStandart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UrunStandart()
        {
            Satis = new HashSet<Satis>();
        }

        public int urunStandartID { get; set; }

        [StringLength(50)]
        public string adi { get; set; }

        [Column(TypeName = "money")]
        public decimal? fiyati { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
