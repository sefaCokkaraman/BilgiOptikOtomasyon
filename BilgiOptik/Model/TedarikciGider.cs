namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TedarikciGider")]
    public partial class TedarikciGider
    {
        public int tedarikciGiderID { get; set; }

        public int? tedarikciID { get; set; }

        public int? odemeTurID { get; set; }

        public int? urunID { get; set; }

        public int miktar { get; set; }

        [Column(TypeName = "money")]
        public decimal birimFiyat { get; set; }

        [Column(TypeName = "money")]
        public decimal toplamTutar { get; set; }

        public DateTime? eklenmeTarihi { get; set; }

        public virtual OdemeTur OdemeTur { get; set; }

        public virtual Tedarikci Tedarikci { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
