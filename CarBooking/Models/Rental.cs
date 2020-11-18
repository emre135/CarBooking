using System;

namespace CarBooking.Models
{
    public class Rental
    {

        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Guid Id { get; set; }
        public Guid CarId { get; set; }
        public string CarModel { get; set; }
        public string Renter { get; set; }

    }
}