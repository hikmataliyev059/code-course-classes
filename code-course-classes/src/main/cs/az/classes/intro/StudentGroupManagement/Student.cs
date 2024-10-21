namespace code_course_classes.main.cs.az.classes.intro.StudentGroupManagement;

public class Student
{
    private static int _idCounter = 0;
    private readonly int _id;
    private string _fullName;
    private double _point;

    public Student(string fullName, double point)
    {
        _id = ++_idCounter;
        _fullName = fullName;
        _point = point;
    }

    public int Id => _id;

    public string FullName
    {
        get => _fullName;
        set => _fullName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Point
    {
        get => _point;
        set => _point = value;
    }

    public void StudentInfo()
    {
        Console.WriteLine($"Student info: fullName: {_fullName},point: {_point}, id: {_id}");
    }
    
}