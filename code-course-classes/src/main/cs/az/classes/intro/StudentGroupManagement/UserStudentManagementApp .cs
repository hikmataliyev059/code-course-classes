namespace code_course_classes.main.cs.az.classes.intro.StudentGroupManagement;

public class UserStudentManagementApp
{
    
    public static void Main(string[] args)
    {
        User user1 = new User("Aliyev Hikmat", "hikmat222@gmail.com", "Password123");
        user1.ShowInfo();

        Student student1 = new Student("Hikmat Aliyev", 85.5);
        student1.StudentInfo();

        Group group = new Group("CS101", 10);
        group.AddStudent(student1);

        Console.WriteLine("All students in group:");
        foreach (var student in group.GetAllStudents())
        {
            student.StudentInfo();
        }

        Student foundStudent = group.GetStudent(student1.Id);
        if (foundStudent != null)
        {
            Console.WriteLine($"Found student with ID {student1.Id}:");
            foundStudent.StudentInfo();
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
    
}