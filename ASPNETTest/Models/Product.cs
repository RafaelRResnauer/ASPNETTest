using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETTest.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Range(1, 10, ErrorMessage = "Quantity must be less than or equal to 10")]
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
