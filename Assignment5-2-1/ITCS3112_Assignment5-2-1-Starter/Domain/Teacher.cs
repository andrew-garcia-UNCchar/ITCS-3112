namespace Assignment5_2_1.Domain;

public sealed class Teacher : Person
{
    public Teacher(Guid id, string name, string email, string department) : base(id, name, email)
    {
        if (string.IsNullOrWhiteSpace(department))
        {
            throw new ArgumentException("Department is required.", nameof(department));
        }
        
        Department =  department;
    }
    
    public string Department { get; set; }
    public override string GetRoleDescription()
    {
        return "Is a Teacher";
    }
}