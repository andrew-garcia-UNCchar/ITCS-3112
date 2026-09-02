namespace Exercise3_1_1;

public class StudentParticipation
{
    public Student StudentInfo { get; private set; }
    public string ActionName { get; }
    public int MaximumPoints { get; }
    public int PointsEarned { get; private set; }

    public StudentParticipation(Student student, int actionChoice)
    {
        if (student == null)
        {
            throw new ArgumentNullException(nameof(student));
        }

        string actionName;
        int maximumPoints;

        var mapping = SetActionChoiceMapping(actionChoice);

        StudentInfo = student;
        ActionName = mapping.actionName;
        MaximumPoints = mapping.maximumPoints;
        PointsEarned = 0;
    }

    private static (string actionName, int maximumPoints) SetActionChoiceMapping(int actionChoice)
    {
        switch (actionChoice)
        {
            case 1:
                return ("Attended Class", 2);
            case 2:
                return ("Attended Office Hours", 5);
            case 3:
                return ("Answered Questions in Class", 3);
            case 4:
                return ("Contributed to Canvas Discussion", 3);
            default:
                throw new ArgumentOutOfRangeException(nameof(actionChoice), actionChoice, null);
        }
    }

    public void UpdatePoints(int newPoints)
    {
        if (newPoints < 0  || newPoints > MaximumPoints)
        {
            throw new ArgumentOutOfRangeException(nameof(newPoints), newPoints, null);
        }

        PointsEarned = newPoints;
    }
}