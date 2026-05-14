using Flight_Git_Works.Enitiy;

namespace Flight_Git_Works.IRepository
{
    public interface IRepositoryFlight
    {
        bool SearchFlights(string departureCity, string arrivalCity, DateTime departureDate);
        bool BookTicket(Flight flight, string passengerName);
    }
}
