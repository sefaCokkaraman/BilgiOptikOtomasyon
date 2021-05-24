namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ajanda")]
    public partial class Ajanda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ajandaID { get; set; }

        public int kullaniicID { get; set; }

        public DateTime tarih { get; set; }

        [Required]
        public string aciklama { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
