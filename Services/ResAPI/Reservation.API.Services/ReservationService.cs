using Reservation.API.Models;
using ReservationAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDto GetResByBukingNumber(int BukingNumber)
        {
            return new ReservationDto()
            {
                Id = (new Random()).Next(100),
                Amount = (new Random()).Next(10000),
                BukingDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(37),
                BukingNumber= BukingNumber

            };
        }
    }
}
