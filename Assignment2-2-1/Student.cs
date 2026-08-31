namespace Assignment2_2_1;

public class Student
{
    public int StudentId { get; private set; }
    public string StudentName { get; private set; } 
    public string StudentEmail { get; private set; }
    public List<Reservation> Reservations { get; private set; }

    public Student(int id, string name, string email)
    {
        StudentId = id;
        StudentName = name;
        StudentEmail = email;
        Reservations = new List<Reservation>();
    }
    
    public int CurrentReservation()
    {
        return Reservations.Count;
    }

    private bool ValidateEmail(string email)
    {
        bool isEmail = False;
        
        if (email.Contains("@"))
            IsEmail = true;
        return IsEmail;
    }
    
}
    
    