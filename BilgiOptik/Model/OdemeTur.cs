namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OdemeTur")]
    public partial class OdemeTur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OdemeTur()
        {
            Satis = new HashSet<Satis>();
            TedarikciGider = new HashSet<TedarikciGider>();
        }

        public int OdemeTurID { get; set; }

        [StringLength(50)]
        public string adi { get; set; }

        public bool? durum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TedarikciGider> TedarikciGider { get; set; }
    }
}
