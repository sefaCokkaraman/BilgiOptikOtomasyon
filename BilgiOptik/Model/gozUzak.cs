namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gozUzak")]
    public partial class gozUzak
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gozUzak()
        {
            GozGecmis = new HashSet<GozGecmis>();
        }

        public int gozUzakID { get; set; }

        public int musteriID { get; set; }

        public decimal? solSph { get; set; }

        public decimal? solCyl { get; set; }

        public decimal? solAxis { get; set; }

        public decimal? sagSph { get; set; }

        public decimal? sagCyl { get; set; }

        public decimal? sagAxis { get; set; }

        public DateTime? tarih { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GozGecmis> GozGecmis { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
