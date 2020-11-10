using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarBooking.Models;

namespace CarBooking.Controllers
{
    public class CarsController : Controller
    {
       


        public IActionResult Index()
        {
            var cars = DbContext.Cars;
            return View(cars);
        }

        public IActionResult Create()
        {
            return View();
        }

        



        [HttpPost] public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                car.Id = Guid.NewGuid();
                DbContext.Cars.Add(car);
                return RedirectToAction("Index");
            }

            return View(car);
        }

        public IActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = DbContext.Cars.FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

       
        [HttpPost]
        public IActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                var carIndex = DbContext.Cars.FindIndex(c => c.Id == car.Id);

                if (carIndex == -1)
                {
                    return NotFound();
                }

                DbContext.Cars[carIndex] = car;

                return RedirectToAction(nameof(Index));
            }

            return View(car);
        }


        public IActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = DbContext.Cars.FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }


        [HttpPost]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var car = DbContext.Cars.FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                return NotFound();
            }

            DbContext.Cars.Remove(car);

            return RedirectToAction("Index");
        }
        
        }


    }


