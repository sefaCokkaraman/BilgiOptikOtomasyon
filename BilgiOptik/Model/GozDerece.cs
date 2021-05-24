namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GozDerece")]
    public partial class GozDerece
    {
        public int gozDereceID { get; set; }

        [StringLength(10)]
        public string ad { get; set; }
    }
}
