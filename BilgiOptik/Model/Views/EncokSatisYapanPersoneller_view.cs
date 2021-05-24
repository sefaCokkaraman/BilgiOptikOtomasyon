namespace BilgiOptik.Model.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EncokSatisYapanPersoneller_view
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kullaniciID { get; set; }

        public int? ToplamSatis { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string kullaniciAdi { get; set; }
    }
}
