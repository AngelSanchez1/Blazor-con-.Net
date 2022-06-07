using DataAcces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Warehouse
    {
        public static List<WareHouseEntity> WareHouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.WareHouses.ToList();
            }
        }

        public void CreateWareHouse(WareHouseEntity oWhareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.WareHouses.Add(oWhareHouse);
                db.SaveChanges();
            }
        }

        public void UpdateWareHouse(WareHouseEntity oWhareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.WareHouses.Update(oWhareHouse);
                db.SaveChanges();
            }
        }

        public void DeleteWareHouse(WareHouseEntity oWhareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.WareHouses.Remove(oWhareHouse);
                db.SaveChanges();
            }
        }
    }
}
