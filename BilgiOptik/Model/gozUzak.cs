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
        public int gozUzakID { get; set; }

        public int musteriID { get; set; }

        public decimal? solSph { get; set; }

        public decimal? solCyl { get; set; }

        public decimal? solAxis { get; set; }

        public decimal? sagSph { get; set; }

        public decimal? sagCyl { get; set; }

        public decimal? sagAxis { get; set; }

        public DateTime? tarih { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
