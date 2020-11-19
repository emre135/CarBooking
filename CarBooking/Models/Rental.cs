using System;
using System.ComponentModel.DataAnnotations;

namespace CarBooking.Models
{
    public class Rental
    {
        [Required]
        public DateTime From { get; set; }
        [Required]
        public DateTime To { get; set; }
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Select a car from the menu")]
        public Guid CarId { get; set; }
        public string CarModel { get; set; }

        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(60, ErrorMessage = "Field cannot contain above 60 characters.")]
        [RegularExpression(@"^[a-öA-Ö]+$", ErrorMessage = "Field may only contain letters.")]
        public string CustomerName { get; set; }

    }
}