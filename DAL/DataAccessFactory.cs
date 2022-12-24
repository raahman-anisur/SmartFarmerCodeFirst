using DAL.EF.Model;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        // Rafi
        public static IRepo<Advisor, int, Advisor> AdvisorDataAccess()
        {
            return new AdvisorRepo();
        }
        public static IRepo<Order, int, Order> OrderDataAccess()
        {
            return new OrderRepo();
        }
        // Shadman

        public static IRepo<Farmer, int, Farmer> FarmerDataAccess()
        {
            return new FarmerRepo();
        }
        public static IRepo<Equipment, int, Equipment> EquipmentDataAccess()
        {
            return new EquipmentRepo();
        }
        public static IRepo<Loan, int, Loan> LoanDataAccess()
        {
            return new LoanRepo();
        }

    }
    
}
