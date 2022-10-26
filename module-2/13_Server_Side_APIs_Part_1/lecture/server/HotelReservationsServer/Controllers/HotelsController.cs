using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.DAO;

namespace HotelReservations.Controllers
{
    // /hotels everything for /hotels come to this controller
    [Route("hotels")]
    // [Route("[controller]")]
    [ApiController] // says that everything that comes in will be in a deserialized form and everything that goes back out will be in a serialized form
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

        // Get and got here with /hotels
        [HttpGet()]
        public List<Hotel> ListHotels()
        {
            return hotelDao.List();
        }

        // GET with /hotels/5 --A get sent from a client searching for a hotel with and ID number of 5
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
