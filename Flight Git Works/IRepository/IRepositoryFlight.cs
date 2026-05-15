using Flight_Git_Works.Enitiy;

namespace Flight_Git_Works.IRepository
{
    public interface IRepositoryFlight
    {
        Task<Flight> AddFlight(Flight flight);    
        Task<List<Flight>> GetAllFlights();
        Task DeleteFlight(int Id);
    }
}
