using HotelApi.DataAcess;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly HotelDataAcess _hotelDataAcess;

        public HotelController(HotelDataAcess hotelDataAcess)
        {
            _hotelDataAcess = hotelDataAcess;
        }

        [HttpGet]
        public async Task<IActionResult> GetHotel()
        {
            var hotels = await _hotelDataAcess.GetAllAsync();

            return Ok(hotels);
        }
    }
}