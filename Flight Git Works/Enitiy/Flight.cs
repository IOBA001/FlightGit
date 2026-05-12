namespace Flight_Git_Works.Enitiy
{
    public class Flight
    {
        public string Id { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public int AvailableSeats { get; set; }
    }
}
