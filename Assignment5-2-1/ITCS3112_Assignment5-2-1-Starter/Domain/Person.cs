namespace Assignment5_2_1.Domain;

public abstract class Person
{
    protected Person(Guid id, string name, string email)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentException("A person identifier is required.", nameof(id));
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("A person name is required.", nameof(name));
        }

        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("A person email is required.", nameof(email));
        }

        Id = id;
        Name = name;
        Email = email;
    }
    
    public Guid Id { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public abstract string GetRoleDescription();
}    