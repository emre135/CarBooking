using System;
using System.ComponentModel.DataAnnotations;

namespace CarBooking.Models
{
    public class Car
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Car model is required.")]
        [StringLength(40, ErrorMessage = "Field cannot contain above 40 characters.")]
        public string? Model { get; set; }

        [Required(ErrorMessage = "Year cannot be empty")]
        [Range(2000, 2020, ErrorMessage = "Year must be between 2000 and 2020")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Mileage is required.")]
        public int? Mileage { get; set; }

        [Required(ErrorMessage = "Price cannot be empty.")]
        [Range(500, 10000, ErrorMessage = "Price range must be between 500 and 10 000")]
        public int? Price { get; set; }

        
        
    }
}