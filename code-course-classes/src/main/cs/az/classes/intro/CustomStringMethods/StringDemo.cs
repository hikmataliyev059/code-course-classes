namespace code_course_classes.main.cs.az.classes.intro.CustomStringMethods;

public class StringDemo
{
    
    public static void Main(string[] args)
    {
        StringMethods stringMethods = new StringMethods();
        string exp = "   Hello, World!   ";

        Console.WriteLine(stringMethods.CustomLastIndexOf(exp, 'W'));

        bool contains = stringMethods.CustomContains(exp, 'h');
        Console.WriteLine(contains);

        string replaced = stringMethods.CustomReplace(exp, "World", "Dunya");
        Console.WriteLine(replaced);

        string substring = stringMethods.CustomSubstring(exp, 2, 5);
        Console.WriteLine(substring);

        string trim = stringMethods.CustomTrim(exp);
        Console.WriteLine(trim);
    }
    
}