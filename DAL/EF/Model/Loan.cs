using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Loan
    {
        public int Id { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int FarmerId { get; set; }
        [Required]
        public string BorrowDate { get; set; }
        [Required]
        public string TodDate { get; set; }
        [Required]
        public string Status { get; set; }
       
    }
}
