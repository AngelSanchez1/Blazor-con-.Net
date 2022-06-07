using DataAcces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_InputOuput
    {
        public List<InOutEntity> InputOuputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInput(InOutEntity oInputOuput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInputOuput);
                db.SaveChanges();
            }
        }

        public void UpdateInput(InOutEntity oInputOuput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInputOuput);
                db.SaveChanges();
            }
        }

        public void DeleteInput(InOutEntity oInputOuput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Remove(oInputOuput);
                db.SaveChanges();
            }
        }
    }
}
