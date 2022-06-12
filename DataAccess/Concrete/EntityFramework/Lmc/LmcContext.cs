using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class LmcContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseMySQL($"server=yourserver;database=yourdb;user=youruser;password=yourpass;SSL Mode=None");
        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Toptanci> Toptancilar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<UyumMarka> UyumMarkalar { get; set; }
        public DbSet<UyumModel> UyumModeller { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<AlinanOdeme> AlinanOdemeler { get; set; }
        public DbSet<YapilanOdeme> YapilanOdemeler { get; set; }
        public DbSet<Satis> Satislar { get; set; }

        public DbSet<SatinAlim> SatinAlimlar { get; set; }

        public DbSet<SatisIade> SatisIadeler { get; set; }

        public DbSet<SatinAlimIade> SatinAlimIadeler { get; set; }
        public DbSet<Onay> Onaylar { get; set; }

        public DbSet<Resim> Resimler { get; set; }
        public DbSet<Sepet> Sepetler { get; set; }
        public DbSet<Kampanya> Kampanyalar { get; set; }
        public DbSet<Begeni> Begeniler { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        
    }
}
