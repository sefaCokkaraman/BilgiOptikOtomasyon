namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BilgiOptikFirma")]
    public partial class BilgiOptikFirma
    {
        [Key]
        public int FirmaID { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(50)]
        public string sifre { get; set; }

        public bool? durum { get; set; }
    }
}
