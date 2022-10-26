using HotelReservations.DAO;
using HotelReservations.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelReservations.Controllers
{
    //[Route("reservations")]
    [Route("[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private static IReservationDao reservationDao;
        private static IHotelDao hotelDao;
        public ReservationsController()
        {
            if (hotelDao == null)
            {
                hotelDao = new HotelMemoryDao();
            }
            if (reservationDao == null)
            {
                reservationDao = new ReservationMemoryDao();
            }
        }

        // GET /reservations
        [HttpGet]
        public ActionResult<List<Reservation>> GetReservations(string name = "")
        {
            List<Reservation> reservations = null;
            reservations = reservationDao.List();
            return Ok(reservations);
        }

        // GET /reservations/4
        [HttpGet("{reservationId}")]
        public ActionResult<Reservation> GetReservation(int reservationId)
        {
            Reservation reservation = null;
            reservation = reservationDao.Get(reservationId);
            if (reservation == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(reservation);
            }
        }

        // POST /reservations
        [HttpPost()]
        public ActionResult<Reservation> CreateReservation(Reservation reservation)
        {
            Reservation result = reservationDao.Create(reservation);
            if (result == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(result);
            }
        }


    }
}
