using DataAcces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StoragesList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.WareHouses)
                    .ToList();
            }
        }

        public static StorageEntity CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();

                return GetStorageById(oStorage.StorageId);
            }
        }

        /* NUEVO MÉTODO */
        public static StorageEntity GetStorageById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.WareHouses)
                    .ToList()
                    .LastOrDefault(s => s.StorageId == id);
            }
        }

        /* NUEVO MÉTODO */
        public static bool IsProductInWarehouse(string id)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList()
                    .Where(p => p.StorageId == id);

                var x = product.Any();
                return x;
            }
        }

        /* NUEVO MÉTODO */
        public static List<StorageEntity> StorageListByWarehouse(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.WareHouses)
                    .Where(s => s.WareHouseId == idWarehouse)
                    .ToList();
            }
        }

        public static void UpdateStorage(StorageEntity oStorage)
        {
            oStorage.LastUpdate = DateTime.Now;

            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}
