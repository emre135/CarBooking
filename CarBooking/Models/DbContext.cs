
using System;
using System.Collections.Generic;



namespace CarBooking.Models
{
    public static class DbContext
    {
        public static List<Car> Cars { get; set; }
        public static List<Rental> Rentals { get; set; }


        static DbContext()
        {
            Cars = new List<Car>();
            Rentals = new List<Rental>();

            Seed();
        }

        private static void Seed()
        {
            var car1 = new Car() { 
                Id = Guid.NewGuid(), 
                Model = "Volvo V90 Cross Country", 
                Year = 2017,
                Mileage = 7456, 
                Price = 3000 };

            var car2 = new Car() {
                Id = Guid.NewGuid(),
                Model = "Mercedes C63 AMG",
                Year = 2012,
                Mileage = 5006, 
                Price = 4500 };

            var car3 = new Car() 
            { Id = Guid.NewGuid(), 
              Model = "Volkswagen Passat 2.0 TDI",
              Year = 2016,
              Mileage = 11000, 
              Price = 2000 };

            var car4 = new Car()
            {
                Id = Guid.NewGuid(),
                Model = "Honda Civic 1.6 vTec",
                Year = 2008,
                Mileage = 14200,
                Price = 1000
            };


            Cars.Add(car1);
            Cars.Add(car2);
            Cars.Add(car3);
            Cars.Add(car4);

            var rentedCar1 = new Rental()
            {
                CustomerName = "Emre Ayhan",
                CarId = car1.Id,
                CarModel = car1.Model,
                From = new DateTime(2020, 11, 19 , 08 , 0, 0),
                To = new DateTime(2020, 11, 20, 08 , 0, 0)
            };

            var rentedCar2 = new Rental()
            {
                CustomerName = "Deniz Sirén",
                CarId = car2.Id,
                CarModel = car2.Model,
                From = new DateTime(2020, 11, 21, 10, 0, 0),
                To = new DateTime(2020, 11, 21, 18, 0, 0)
            };

            var rentedCar3 = new Rental()
            {
                CustomerName = "Elias Ekengren",
                CarId = car3.Id,
                CarModel = car3.Model,
                From = new DateTime(2020, 11, 25, 16, 3, 0),
                To = new DateTime(2020, 11, 26, 10, 0, 0)
            };

            var rentedCar4 = new Rental()
            {
                CustomerName = "Ridwan Saadidris",
                CarId = car4.Id,
                CarModel = car4.Model,
                From = new DateTime(2020, 11, 22, 10, 0, 0),
                To = new DateTime(2020, 11, 22, 18, 0, 0)
            };

            Rentals.Add(rentedCar1);
            Rentals.Add(rentedCar2);
            Rentals.Add(rentedCar3);
            Rentals.Add(rentedCar4);

         




        }


    }
}