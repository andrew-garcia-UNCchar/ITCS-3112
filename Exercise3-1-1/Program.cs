namespace Exercise3_1_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the student's first name: ");
        var firstName = Console.ReadLine();
        
        Console.WriteLine("Enter the student's last name: ");
        var lastName = Console.ReadLine();

        Console.WriteLine("Enter the student's ID: ");
        var studentId = Console.ReadLine();

        Console.WriteLine("Enter the student's Charlotte email: ");
        var email = Console.ReadLine();

        Student student = new Student(firstName, lastName, studentId, email);
        
        Console.WriteLine("\n" +
                          "Participation Actions\n" +
                          "1. Attended Class - maximum 2points\n" +
                          "2. Attended Office Hours- maximum 2 points\n" +
                          "3. Answered Questions in Class - maximum 3 points\n" +
                          "4. Contributed to Canvas Discussion - maximum 3 points");
        
        Console.WriteLine("Enter the action number:");
        var actionChoice = Convert.ToInt32(Console.ReadLine());
        
        StudentParticipation participation = new StudentParticipation(student, actionChoice);
        
        Console.WriteLine("\nParticipation Record");
        Console.WriteLine($"Student:  {participation.StudentInfo.FirstName}  {participation.StudentInfo.LastName}");
        Console.WriteLine($"Student ID:  {participation.StudentInfo.StudentId}");
        Console.WriteLine($"Student ID:  {participation.StudentInfo.StudentId}");
        Console.WriteLine($"Action:  {participation.ActionName}");
        Console.WriteLine($"Maximum Points:  {participation.MaximumPoints}");
        Console.WriteLine($"Points Earned:  {participation.PointsEarned}");
        
        Console.WriteLine("\nEnter Points for update:\n");
        var points = Convert.ToInt32(Console.ReadLine());
        participation.UpdatePoints(points);
        
        Console.WriteLine($"Points earned:  {participation.PointsEarned}");
    }
}