using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAcces
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<InOutEntity> InOuts { get; set; }

        public DbSet<WareHouseEntity> WareHouses { get; set; }

        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=Pixeles; Database=InventoryDb; User Id=sa; Password=q");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumería" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }
                );

            modelBuilder.Entity<WareHouseEntity>().HasData(
                new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Bodega Central", WareHouseAddress = "Calle 8 con 23" },
                new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Bodega Norte", WareHouseAddress = "Calle norte con occidente" },
                new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Bodega Sur", WareHouseAddress = "Calle sur con sureste" }
                );

            modelBuilder.Entity<ProductEntity>().HasData(
               new ProductEntity { ProductId = "ASJ-98745", ProductName = "Crema para manos marca Tersa", ProductDescription = "", CategoryId = "PRF" },
               new ProductEntity { ProductId = "RPT-69965", ProductName = "Pastillas para la garganta LESUS", ProductDescription = "", CategoryId = "SLD" }
               );
        }
    }
}
