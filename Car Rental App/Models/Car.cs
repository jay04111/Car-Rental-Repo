using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental_App.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Required]
        public string CarName { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public char VIN { get; set; }

        [Required]
        public string CarDescription { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Brand { get; set; }

        public string PhotoPath { get; set; }
    }
}
