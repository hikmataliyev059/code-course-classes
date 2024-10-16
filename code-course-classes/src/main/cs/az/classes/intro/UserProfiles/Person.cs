namespace code_course_classes.main.cs.az.classes.intro.UserProfiles;

public class Person
{
    string _fullName;
    int _age;
    string _phoneNumber;

    public string FullName
    {
        get => _fullName;
        set
        {
            if (IsValidFullName(value))
            {
                _fullName = value;
            }
            else
            {
                Console.WriteLine("Full name must contain at least two words, both starting with uppercase letters.");
            }
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            if (_age < 0)
            {
                Console.WriteLine("Age must be greater than zero.");
            }

            _age = value;
        }
    }

    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            if (!value.StartsWith("+994"))
            {
                _phoneNumber = "+994" + value.TrimStart('0');
            }
            else
            {
                _phoneNumber = value;
            }
        }
    }

    public bool IsValidFullName(string fullName)
    {
        var parts = fullName.Split(' ');
        return parts.Length >= 2 &&
               char.IsUpper(fullName[0]) &&
               char.IsUpper(fullName[fullName.IndexOf(' ') + 1]);
    }
    
}