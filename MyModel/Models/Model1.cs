using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MyModel.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<aksesuarlar> aksesuarlar { get; set; }
        public virtual DbSet<detaylar> detaylar { get; set; }
        public virtual DbSet<gelenler> gelenler { get; set; }
        public virtual DbSet<iletisim> iletisim { get; set; }
        public virtual DbSet<sitesabitleri> sitesabitleri { get; set; }
        public virtual DbSet<slider> slider { get; set; }
        public virtual DbSet<urunkategoriler> urunkategoriler { get; set; }
        public virtual DbSet<urunler> urunler { get; set; }
        public virtual DbSet<urunresimler> urunresimler { get; set; }
        public virtual DbSet<yenilemeonarim> yenilemeonarim { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
