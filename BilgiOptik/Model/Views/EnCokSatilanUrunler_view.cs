namespace BilgiOptik.Model.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EnCokSatilanUrunler_view
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int urunID { get; set; }

        [StringLength(500)]
        public string urunAdi { get; set; }

        public int? toplamMiktari { get; set; }
    }
}
