namespace BilgiOptik.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GozGecmis
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gozGecmisID { get; set; }

        public int? gozDaimiID { get; set; }

        public int? gozYakinID { get; set; }

        public int? gozUzakID { get; set; }

        public virtual gozDaimi gozDaimi { get; set; }

        public virtual gozUzak gozUzak { get; set; }

        public virtual gozYakin gozYakin { get; set; }

        public virtual Satis Satis { get; set; }
    }
}
