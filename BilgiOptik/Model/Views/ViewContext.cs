using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BilgiOptik.Model.Views
{
    public partial class ViewContext : DbContext
    {
        public ViewContext()
            : base("name=ViewContext")
        {
        }
        
        public virtual DbSet<EnCokSatilanUrunler_view> EnCokSatilanUrunler_view { get; set; }
        public virtual DbSet<EncokSatisYapanPersoneller_view> EncokSatisYapanPersoneller_view { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
