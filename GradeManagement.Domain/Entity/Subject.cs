namespace GradeManagement.Domain.Entity;

public class Subject
{

    public Guid Id { get; init; }
    public string Name { get; set; }
    public Course Course { get; set; }
}