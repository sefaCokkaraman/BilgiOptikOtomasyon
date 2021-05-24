namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sikayet")]
    public partial class Sikayet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sikayetID { get; set; }

        public int musteriID { get; set; }

        public int satisID { get; set; }

        public string musteriSikayet { get; set; }

        public DateTime? tarih { get; set; }

        public virtual Musteri Musteri { get; set; }

        public virtual Satis Satis { get; set; }
    }
}
