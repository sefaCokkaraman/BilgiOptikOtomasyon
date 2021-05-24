namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UrunOzellik")]
    public partial class UrunOzellik
    {
        public int UrunOzellikID { get; set; }

        public int? urunDetayID { get; set; }

        public int? ozellikID { get; set; }

        [StringLength(50)]
        public string deger { get; set; }

        public virtual Ozellik Ozellik { get; set; }

        public virtual UrunDetay UrunDetay { get; set; }
    }
}
