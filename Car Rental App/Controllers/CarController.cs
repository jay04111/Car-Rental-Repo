using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Car_Rental_App.Models;
using Car_Rental_App.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Car_Rental_App.Controllers
{
    public class CarController : Controller
    {
        private readonly AppDbContext _context;

        private readonly UserManager<Customer> userManager;
        private readonly IHostingEnvironment hostingEnvironment;

        public CarController(AppDbContext context,
                            IHostingEnvironment hostingEnvironment,
                             UserManager<Customer> userManager)
        {
            _context = context;
            this.userManager = userManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CarCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Car newCar = new Car
                {
                    CarName = model.CarName,
                    Color = model.Color,
                    Category = model.Category,
                    VIN = model.VIN,
                    CarDescription = model.CarDescription,
                    Model = model.Model,
                    Brand = model.Brand,
                    PhotoPath = uniqueFileName
                };

                _context.Add(newCar);
                _context.SaveChanges();
                /*
                book.customer = await _context.Customers.FindAsync(userManager.GetUserId(HttpContext.User));
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction("myBooks", "book");*/
                return RedirectToAction("index","home");
            }
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View();
        }


    }
}
