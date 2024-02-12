using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechTroveLaptops.Models
{
        public class Order
        {
            [Key]
            public int OrderId { get; set; }

            [Required]
            public int LaptopId { get; set; }

            public Laptop Laptop { get; set; }

            [Required]
            [Range(1, int.MaxValue, ErrorMessage = "Please enter a value greater than or equal to {1}")]
            public int Quantity { get; set; }

            [Required]
            [StringLength(100)]
            public string CustomerName { get; set; }

            [Required]
            [StringLength(100)]
            public string CustomerEmail { get; set; }

            [Required]
            public DateTime OrderDate { get; set; }
        }
}