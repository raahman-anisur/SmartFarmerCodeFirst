using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class LoanRepo: Repo,IRepo<Loan, int, Loan>
    {
        public Loan Add(Loan obj)
        {
            db. Loan.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public Loan Delete(int id)
        {
            var dbobj = Get(id);
            if (dbobj != null)
            {
                db.Loan.Remove(dbobj);
                if (db.SaveChanges() > 0)
                {
                    return dbobj;
                }
                return null;
            }
            return null;

        }

        public List<Loan> Get()
        {
            return db. Loan.ToList();
        }

        public Loan Get(int id)
        {
            return db. Loan.Find(id);
        }

        public Loan Update(Loan obj)
        {
            var dbco = Get(obj.Id);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        

    }
}
