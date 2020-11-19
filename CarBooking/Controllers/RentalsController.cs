using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarBooking.Helpers;
using CarBooking.Models;
using CarBooking.Models.ViewModels;


namespace CarBooking.Controllers
{
    public class RentalsController : Controller
    {
        public IActionResult Index()
        {
            var rentals = DbContext.Rentals;
            return View(rentals);
        }

        public IActionResult Create()
        {
            var newRentalViewModel = new NewRentalViewModel() { Cars = DbContext.Cars };
            return View(newRentalViewModel);

        }

        [HttpPost]
        public IActionResult Create(Rental rental)
        {
            var car = DbContext.Cars.FirstOrDefault(c => c.Id == rental.CarId);
            rental.Id = Guid.NewGuid();

            rental.CarModel = car.Model;

            DbContext.Rentals.Add(rental);

            return RedirectToAction("Index");

        }

        private bool ValidateBooking(Rental rental)
        {
            bool isValid = true;

           
            if (rental.From > rental.To)
            {
                ModelState.AddModelError("Booking.From", "Start date cannot be after end date");
                var newRentalViewModel = new NewRentalViewModel() { Cars = DbContext.Cars, Rental = rental };
                isValid = false;
            }

            
            List<Rental> rentalFromDb = DbContext.Rentals.Where(r => r.CarId == rental.CarId).ToList();

            
            foreach (var currentRentals in rentalFromDb)
            {
                if (DateHelpers.HasSharedDateIntervals(rental.From, rental.To, currentRentals.From, currentRentals.To))
                {
                    ModelState.AddModelError("Booking.From", "Date already occupied.");
                    var newRentalViewModel = new NewRentalViewModel() { Cars = DbContext.Cars, Rental = rental };
                    isValid = false;
                }
            }

            return isValid;
        }
        public IActionResult Edit(Guid id)
        {
         
            var rental = DbContext.Rentals.FirstOrDefault(r => r.Id == id);

            var EditRentalViewModel = new EditRentalViewModel() { Rental = rental, Cars = DbContext.Cars};
            return View(EditRentalViewModel);



        }
        [HttpPost]
        public IActionResult Edit(Rental rental)
        {
            rental.CarModel = DbContext.Cars.FirstOrDefault(cM => cM.Id == rental.CarId).Model;

            var rentalId = DbContext.Rentals.FindIndex(rI => rI.Id == rental.Id);

            if (rentalId == -1)
            {
                return NotFound();
            }

            DbContext.Rentals[rentalId] = rental;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = DbContext.Rentals.FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var rental = DbContext.Rentals.FirstOrDefault(r => r.Id == id);

            if (rental == null)
            {
                return NotFound();
            }

            DbContext.Rentals.Remove(rental);

            return RedirectToAction("Index");
        }


    }
}
