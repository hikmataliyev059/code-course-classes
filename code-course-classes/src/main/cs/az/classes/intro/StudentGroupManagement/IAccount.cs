namespace code_course_classes.main.cs.az.classes.intro.StudentGroupManagement;

public interface IAccount
{
    bool PasswordChecker(string password);
    void ShowInfo();
}