namespace code_course_classes.main.cs.az.classes.intro.UserProfiles;

public class UserProfileApp
{
    
    public static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.FullName = "John Doe";
        person1.Age = 25;
        person1.PhoneNumber = "501234567";

        Person person2 = new Person();
        person2.FullName = "jane doe";
        person2.Age = -5;             
        person2.PhoneNumber = "+994551234567";

        Console.WriteLine($"Ad: {person1.FullName}, Yaş: {person1.Age}, Telefon: {person1.PhoneNumber}");
        Console.WriteLine($"Ad: {person2.FullName}, Yaş: {person2.Age}, Telefon: {person2.PhoneNumber}");
    }
    
}