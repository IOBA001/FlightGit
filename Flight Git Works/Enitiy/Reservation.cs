namespace Flight_Git_Works.Enitiy
{
    public class Reservation
    {
        public int Id { get; set; }
        public string ReservationNumber { get; set; }
        public string PassengerName { get; set; }
        public Flight Flight { get; set; }
    }
}
