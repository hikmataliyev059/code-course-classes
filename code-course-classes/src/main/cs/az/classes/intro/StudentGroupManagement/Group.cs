namespace code_course_classes.main.cs.az.classes.intro.StudentGroupManagement;

public class Group
{
    private string _groupNo;
    private int _studentLimit;
    private Student[] _students;
    private int _currentStudentCount = 0;

    public Group(string groupNo, int studentLimit)
    {
        if (!CheckGroupNo(groupNo))
        {
            Console.WriteLine("Invalid group number format.");
        }

        if (studentLimit < 5 || studentLimit > 18)
        {
            Console.WriteLine("Student limit must be between 5 and 18.");
        }

        _groupNo = groupNo;
        _studentLimit = studentLimit;
        _students = new Student[studentLimit];
    }

    public bool CheckGroupNo(string groupNo)
    {
        return groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) &&
               char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]);
    }

    public void AddStudent(Student student)
    {
        if (_currentStudentCount < _studentLimit)
        {
            _students[_currentStudentCount++] = student;
        }
        else
        {
            Console.WriteLine("Student limit reached! Cannot add more students.");
        }
    }

    public Student GetStudent(int? id)
    {
        if (id == null)
        {
            return null;
        }

        foreach (var student in _students)
        {
            if (student != null && student.Id == id)
            {
                return student;
            }
        }

        return null;
    }

    public Student[] GetAllStudents()
    {
        return _students;
    }
    
}