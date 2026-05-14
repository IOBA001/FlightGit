using Dapper;
using Flight_Git_Works.Enitiy;
using Flight_Git_Works.IRepository;
using System.Data;

namespace Flight_Git_Works.Repository
{
    public class RepositoryFlight : IRepositoryFlight
    {
        private readonly IDbConnection _dbConnection;
        public RepositoryFlight(IDbConnection dbConnection) 
        {
            _dbConnection = dbConnection;
        }
        public async Task<Flight> AddFlight(Flight flight)
        {
            var addflight = await _dbConnection.ExecuteAsync("CreateFlight", new
            {
                Id = flight.Id,
                FlightNumber = flight.FlightNumber,
                DepartureCity = flight.DepartureCity,
                ArrivalCity = flight.ArrivalCity,
                DepartureTime = flight.DepartureTime,
                AvailableSeats = flight.AvailableSeats,
            },
                 commandType: CommandType.StoredProcedure);
            return addflight > 0 ? flight : null;
        }

        Task IRepositoryFlight.DeleteFlight(int Id)
        {
            throw new NotImplementedException();
        }

        Task<List<Flight>> IRepositoryFlight.GetAllFlights()
        {
            throw new NotImplementedException();
        }
    }
}
