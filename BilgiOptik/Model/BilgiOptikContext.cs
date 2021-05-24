using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BilgiOptik.Model
{
    public partial class BilgiOptikContext : DbContext
    {
        public BilgiOptikContext()
            : base("name=BilgiOptikContext")
        {
        }

        public virtual DbSet<Ajanda> Ajanda { get; set; }
        public virtual DbSet<Goz> Goz { get; set; }
        public virtual DbSet<gozDaimi> gozDaimi { get; set; }
        public virtual DbSet<GozDerece> GozDerece { get; set; }
        public virtual DbSet<GozNumara> GozNumara { get; set; }
        public virtual DbSet<gozUzak> gozUzak { get; set; }
        public virtual DbSet<gozYakin> gozYakin { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<NotDefteri> NotDefteri { get; set; }
        public virtual DbSet<OdemeTur> OdemeTur { get; set; }
        public virtual DbSet<Ozellik> Ozellik { get; set; }
        public virtual DbSet<Satis> Satis { get; set; }
        public virtual DbSet<Sikayet> Sikayet { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tedarikci> Tedarikci { get; set; }
        public virtual DbSet<TedarikciGider> TedarikciGider { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<UrunDetay> UrunDetay { get; set; }
        public virtual DbSet<UrunOzellik> UrunOzellik { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<gozDaimi>()
                .Property(e => e.solSph)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozDaimi>()
                .Property(e => e.solCyl)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozDaimi>()
                .Property(e => e.solAxis)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozDaimi>()
                .Property(e => e.sagSph)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozDaimi>()
                .Property(e => e.sagCyl)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozDaimi>()
                .Property(e => e.sagAxis)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozUzak>()
                .Property(e => e.solSph)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozUzak>()
                .Property(e => e.solCyl)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozUzak>()
                .Property(e => e.solAxis)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozUzak>()
                .Property(e => e.sagSph)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozUzak>()
                .Property(e => e.sagCyl)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozUzak>()
                .Property(e => e.sagAxis)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozYakin>()
                .Property(e => e.solSph)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozYakin>()
                .Property(e => e.solCyl)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozYakin>()
                .Property(e => e.solAxis)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozYakin>()
                .Property(e => e.sagSph)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozYakin>()
                .Property(e => e.sagCyl)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gozYakin>()
                .Property(e => e.sagAxis)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.Urun)
                .WithRequired(e => e.Kategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.maas)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Ajanda)
                .WithRequired(e => e.Kullanici)
                .HasForeignKey(e => e.kullaniicID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Musteri)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.NotDefteri)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Satis)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marka>()
                .HasMany(e => e.Urun)
                .WithRequired(e => e.Marka)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.telefon)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.gozDaimi)
                .WithRequired(e => e.Musteri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.gozUzak)
                .WithRequired(e => e.Musteri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.gozYakin)
                .WithRequired(e => e.Musteri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.Satis)
                .WithRequired(e => e.Musteri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.Sikayet)
                .WithRequired(e => e.Musteri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Satis>()
                .Property(e => e.toplamTutar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Satis>()
                .HasMany(e => e.Sikayet)
                .WithRequired(e => e.Satis)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tedarikci>()
                .Property(e => e.telefon)
                .HasPrecision(13, 0);

            modelBuilder.Entity<Tedarikci>()
                .HasMany(e => e.Urun)
                .WithRequired(e => e.Tedarikci)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TedarikciGider>()
                .Property(e => e.birimFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TedarikciGider>()
                .Property(e => e.toplamTutar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urun>()
                .Property(e => e.urunEkartmani)
                .IsUnicode(false);

            modelBuilder.Entity<Urun>()
                .Property(e => e.alisFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urun>()
                .Property(e => e.satisFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.UrunDetay)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UrunDetay>()
                .Property(e => e.tutar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Yetki>()
                .HasMany(e => e.Kullanici)
                .WithRequired(e => e.Yetki)
                .WillCascadeOnDelete(false);
        }
    }
}
