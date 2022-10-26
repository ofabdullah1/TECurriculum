using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.DAO;

namespace HotelReservations.Controllers
{
    //    /hotels
    [Route("hotels")]
    //[Route("[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private static IHotelDao hotelDao;

        public HotelsController()
        {
            if (hotelDao == null)
            {
                hotelDao = new HotelMemoryDao();
            }
        }

        // GET /hotels
        [HttpGet()]
        public List<Hotel> ListHotels()
        {
            return hotelDao.List();
        }


        // GET /hotels/5
        [HttpGet("{id}")]
        public ActionResult<Hotel> GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }
            else
            {
                return NotFound();
            }
        }
    }
}
