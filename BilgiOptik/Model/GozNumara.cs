namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GozNumara")]
    public partial class GozNumara
    {
        public int gozNumaraID { get; set; }

        public int gozID { get; set; }

        public int gozDereceID { get; set; }

        public int? musteriID { get; set; }

        [StringLength(10)]
        public string sph { get; set; }

        [StringLength(10)]
        public string cyl { get; set; }

        [StringLength(10)]
        public string axis { get; set; }

        public DateTime? tarih { get; set; }
    }
}
