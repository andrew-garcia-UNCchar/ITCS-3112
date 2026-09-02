using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

namespace Exercise3_1_1;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string StudentId { get; set; }
    public string Email { get; set; }

    public Student(
        string firstName,
        string lastName,
        string studentId,
        string email)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentException(
                "Invalid first name, first name must not contain empty space.", nameof(firstName));
        }
        
        if (string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException(
                "Invalid last name, last name must not contain empty space.", nameof(lastName));
        }

        if (studentId.Length != 9 || !studentId.StartsWith("800") || !Int64.TryParse(studentId, out long id))
        {
            throw new ArgumentException(
                "Invalid student id, student id must be 9 digits in lenght, start with '800', and comprised of only integers.", nameof(studentId));
        }
        
        if (!email.EndsWith("@charlotte.edu"))
        {
            throw new ArgumentException(
                "Invalid email address, email must end with '@charlotte.edu'.", nameof(email));
        }

        FirstName = firstName;
        LastName = lastName;
        StudentId = studentId;
        Email = email;
    }
    
}