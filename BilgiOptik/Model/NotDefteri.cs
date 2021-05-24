namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotDefteri")]
    public partial class NotDefteri
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int notDefteriID { get; set; }

        public int kullaniciID { get; set; }

        public DateTime? tarih { get; set; }

        public string notu { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
