﻿using System;

namespace CarBooking.Models
{
    public class Car
    {
        public Guid Id { get; set; }

        public int CarId { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public int Mileage { get; set; }

        public int Price { get; set; }
    }
}