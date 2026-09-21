namespace Assignment5_2_1.Domain;

public sealed class Teacher : Person, IParticipationAdministrator
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
        return $"Teacher in {Department}";
    }

    public ParticipationRecord RecordParticipation(
        Guid id,
        Student student,
        ParticipationCategory category,
        DateTime occurredAt,
        string? notes = null)
    {
        return new ParticipationRecord(
            id,
            student,
            category,
            occurredAt,
            notes);
    }

    public void UpdateParticipationNotes(ParticipationRecord record, string? notes)
    {
        record.UpdateNotes(notes);
    }
 
}