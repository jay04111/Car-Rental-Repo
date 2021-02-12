using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental_App.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required]
        public string ReturnLocation { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public string PickupLocation { get; set; }

        [Required]
        public int CarVIN { get; set; }

        [Required]
        public DateTime PickupDate { get; set; }

    }
}
