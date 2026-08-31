namespace Assignment2_2_1;

public class Reservation
{
    public bool ReservationStatus { get; private set; }
    public DateTime RequestTime { get; private set; }
    public Student Student { get; private set; }
    public string ReservationItem { get; private set; }    
    
    public Reservation(bool status, DateTime time, Student student, string item)
    {
        ReservationStatus = status;
        RequestTime = time;
        Student = student;
        ReservationItem = item;
    }

    public void SetReservation()
    {
         if (ValidateRequestTime())
         {
            ReservationStatus = true;
            Student.Reservations.Add(this);
        }
    }

    private bool ValidateRequestTime()
    {
        if (RequestTime < DateTime.Now)
            return false;
        return true;
    }
}