using Flight_Git_Works.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Flight_Git_Works.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightReservationSystemController : ControllerBase
    {
        private readonly IFlightReservationSystemRepository _repos;
        public FlightReservationSystemController(IFlightReservationSystemRepository repos)
        {
            _repos = repos;
        }
        [HttpGet("Get-Search-Flight")]
        public async Task<IActionResult> GetFlight(string FlightNumber)
        {
            var search = await _repos.SearchFlight(FlightNumber);
            if (search == null) BadRequest();
            return Ok(search);

        }
        [HttpPost("Create-Booking")]
        public async Task<IActionResult> CreateBookings(string flightNumber, string passengerName)
        {
            var create = await _repos.CreateBooking(flightNumber, passengerName);
            if (create) return Ok("WARMATEBIT DAIJAVSHNA");
            return BadRequest("RAGACA CHEPEAA!!");
        }
        [HttpDelete("Delete-Booking")]
        public async Task<IActionResult> Delete(string reservacionNumber)
        {
            var delete = await _repos.deleteBooking(reservacionNumber);
            if (delete) return Ok("WARMATEBIT WAISHALA");
            return BadRequest("SHECDOMAA!!");
        }
    }
}
