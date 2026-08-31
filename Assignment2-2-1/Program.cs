namespace Assignment2_2_1;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(1, "John", "john@charlotte.edu");

        Reservation reservation = new Reservation(
            false
            , new DateTime(2027, 10, 1)
            , student
            , "Calculator"
            );
        
        reservation.SetReservation();
        
        Console.WriteLine($"Current Reservations: {student.CurrentReservations()}");
        
        Console.WriteLine($"Student: {reservation.Student.StudentName}");
        Console.WriteLine($"Item: {reservation.ReservationItem}");
        Console.WriteLine($"Request Time: {reservation.RequestTime}");
        Console.WriteLine($"Reservation Status: {reservation.ReservationStatus}");

    }
}