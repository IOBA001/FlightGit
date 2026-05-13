using Dapper;
using Flight_Git_Works.Enitiy;
using Flight_Git_Works.IRepository;
using System.Data;

namespace Flight_Git_Works.Repository
{
    public class FlightReservationSystemRepository : IFlightReservationSystemRepository
    {
        private readonly IDbConnection _connection;
        public FlightReservationSystemRepository(IDbConnection connection)
        {
            _connection = connection;   
        }
        public async Task<bool> CreateBooking(string flightNumber, string passengerName)
        {
            var create = await _connection.ExecuteAsync("spBookTicket", new
            {
                FlightNumber = flightNumber,
                PassengerName = passengerName
            }, commandType: CommandType.StoredProcedure);
            return create > 0;
        }

        public async Task<bool> deleteBooking(string reservacionNumber)
        {
            var delete = await _connection.ExecuteAsync("spCancelReservation", new { ReservationNumber = reservacionNumber }, commandType: CommandType.StoredProcedure);

            return delete > 0;
        }

        public async Task<List<Flight>> SearchFlight(string FlightNumber)
        {
            var flth = await _connection.QueryAsync<Flight>("spSearchflight", new { FlightNumber = FlightNumber }, commandType: CommandType.StoredProcedure);
            return flth.ToList();
        }
    }
}
