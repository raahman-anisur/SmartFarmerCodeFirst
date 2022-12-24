using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class FarmerContext : DbContext
    {
        public DbSet<Advisor> Advisors { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<Farmer> Farmers { set; get; }
        public DbSet<Equipment> Equipment { set; get; }
        public DbSet<Loan> Loan { set; get; }   
    }
}
