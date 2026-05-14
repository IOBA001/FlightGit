using Flight_Git_Works.Enitiy;

namespace Flight_Git_Works.IRepository
{
    public interface IReservationRepository
    {
        bool CancelReservation(Reservation reservation);

    }
}
