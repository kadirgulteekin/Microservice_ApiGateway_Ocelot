using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Models
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public int BukingNumber { get; set; }
        public DateTime? CheckinDate { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public DateTime? BukingDate { get; set; }
        public double Amount { get; set; }

    }
}
