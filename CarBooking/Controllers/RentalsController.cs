using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBooking.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.Controllers
{
    public class RentalsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       // public IActionResult Create()
        //{
           // var newRental = DbContext.Cars.FindIndex(c => c.Id == car.Id);
           // return View();
       // }
    }
}
