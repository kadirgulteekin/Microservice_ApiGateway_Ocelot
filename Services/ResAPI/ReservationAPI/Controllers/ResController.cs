using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Infrastructure;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ResController(IReservationService ReservationService)
        {
            reservationService = ReservationService;
        }


        [HttpGet("{Id}")]
        public Reservation.API.Models.ReservationDto Get(int Id)
        {
            return reservationService.GetResByBukingNumber(Id);
        }
    }
}
