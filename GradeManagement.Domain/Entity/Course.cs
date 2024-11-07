namespace GradeManagement.Domain.Entity;

public class Course
{
    private List<Subject> _subjects;

    public Course(string name)
    {
        _subjects = [];
        Name = name;
    }

    public Guid Id { get; init; }
    public string Name { get; private set; }

    public IReadOnlyCollection<Subject> Subjects
    {
        get => _subjects.ToArray();
    }

    public void AddSubject(Subject subject)
    {
        _subjects.Add(subject);
    }
}