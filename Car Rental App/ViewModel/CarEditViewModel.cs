using Car_Rental_App.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental_App.ViewModel
{
    public class CarEditViewModel : CarCreateViewModel
    {
        public int Id { get; set; }
        public string ExistingPhotoPath{ get; set; }
    }
}
