using Flight_Git_Works.Enitiy;

namespace Flight_Git_Works.IRepository
{
    public interface IFlightReservationSystemRepository
    {
        Task<List<Flight>> SearchFlight(string FlightNumber);
        Task<bool> CreateBooking(string flightNumber, string passengerName);
        Task<bool> deleteBooking(string reservacionNumber);
    }
}
