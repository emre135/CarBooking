
using System;
using System.Collections.Generic;



namespace CarBooking.Models
{
    public static class DbContext
    {
        public static List<Car> Cars { get; set; }
        public static List<Booking> Bookings { get; set; }


        static DbContext()
        {
            Cars = new List<Car>();
            Bookings = new List<Booking>();

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


            Cars.Add(car1);
            Cars.Add(car2);
            Cars.Add(car3);
        }


    }
}