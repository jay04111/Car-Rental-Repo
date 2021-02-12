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
        public string Color { get; set; }

        [Required]
        public int VIN { get; set; }

        [Required]
        public string CarDescription { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public string Brand { get; set; }
    }
}
