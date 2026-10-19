using HotelApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHotel()
        {
            Hotel hotel = new Hotel
            {
                HotelId = 1,
                Name = "Hotel One",
                CreatedByUser = 1,
                DateCreated = DateTimeOffset.Now,
                DateUpdated = DateTimeOffset.Now
            };

            List<Hotel> hotels = new List<Hotel>();
            hotels.Add(hotel);

            return Ok(hotels);
        }
    }
}