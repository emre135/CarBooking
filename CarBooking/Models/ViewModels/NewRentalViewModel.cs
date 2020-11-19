
using System.Collections.Generic;


namespace CarBooking.Models.ViewModels
{
    public class NewRentalViewModel
    {
        public List<Car> Cars { get; set; } 
        public Rental Rental { get; set; }
    }
}
