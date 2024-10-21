namespace code_course_classes.main.cs.az.classes.intro.StudentGroupManagement;

public class User : IAccount
{
    private static int _idCounter = 0;
    private readonly int _id;
    private string _fullName;
    private string _email;
    private string _password;

    public User(string fullName, string email, string password)
    {
        _id = ++_idCounter;
        _fullName = fullName;
        _email = email;

        if (PasswordChecker(password))
        {
            _password = password;
        }
        else
        {
            Console.WriteLine("Invalid password");
        }
    }

    public int Id => _id;

    public string FullName
    {
        get => _fullName;
        set => _fullName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Email
    {
        get => _email;
        set => _email = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Password
    {
        get => _password;
        set
        {
            if (PasswordChecker(value))
            {
                _password = value;
            }
            else
            {
                Console.WriteLine("Invalid password");
            }
        }
    }

    public bool PasswordChecker(string password)
    {
        return password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) &&
               password.Any(char.IsDigit);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Id: {Id}, Fullname: {_fullName}, Email: {_email}");
    }
    
}