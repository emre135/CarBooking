using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBooking.Models.ViewModels
{
    public class EditRentalViewModel
    {
        public List<Car> Cars { get; set; }
        public Rental Rental { get; set; }
    }
}
