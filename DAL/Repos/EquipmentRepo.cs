using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EquipmentRepo:Repo,IRepo<Equipment,int , Equipment>
    {
        public Equipment Add(Equipment obj)
        {
            db.Equipment.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public Equipment Delete(int id)
        {
            var dbobj = Get(id);
            if (dbobj != null)
            {
                db.Equipment.Remove(dbobj);
                if (db.SaveChanges() > 0)
                {
                    return dbobj;
                }
                return null;
            }
            return null;

        }

        public List<Equipment> Get()
        {
            return db.Equipment.ToList();
        }

        public Equipment Get(int id)
        {
            return db.Equipment.Find(id);
        }

        public Equipment Update(Equipment obj)
        {
            var dbco = Get(obj.Id);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
       
    }
}
