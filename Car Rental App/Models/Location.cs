using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental_App.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Required]
        public String Address { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required]
        public String State { get; set; }

        [Required]
        public String Country { get; set; }
    }
}
