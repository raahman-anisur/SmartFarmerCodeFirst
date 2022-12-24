using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Equipment
    {
        public int Id { get; set; }
        [Required]
        public int SellerID { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Quantity { get; set; }
        
    }
}
