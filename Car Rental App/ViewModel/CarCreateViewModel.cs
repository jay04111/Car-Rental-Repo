using Car_Rental_App.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental_App.ViewModel
{
    public class CarCreateViewModel
    {
        [Required]
        [Display(Name = "Car Name")]
        public string CarName { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public char VIN { get; set; }

        [Required]
        [Display(Name = "Car Description")]
        public string CarDescription { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Brand { get; set; }

        [Display(Name = "Upload Car Image")]
        public IFormFile Photo { get; set; }
    }
}
