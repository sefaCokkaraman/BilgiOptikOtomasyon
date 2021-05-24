namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Goz")]
    public partial class Goz
    {
        public int gozID { get; set; }

        [StringLength(10)]
        public string ad { get; set; }
    }
}
