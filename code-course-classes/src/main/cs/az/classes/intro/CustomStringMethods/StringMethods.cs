namespace code_course_classes.main.cs.az.classes.intro.CustomStringMethods;

public class StringMethods
{
    
    public int CustomLastIndexOf(string source, char value)
    {
        {
            if (string.IsNullOrEmpty(source))
            {
                return -1;
            }

            int length = source.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                if (i < length && source[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
    }

    public bool CustomContains(string source, char value)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        foreach (char c in source)
        {
            if (c == value)
            {
                return true;
            }
        }

        return false;
    }

    public string CustomReplace(string source, string oldValue, string newValue)
    {
        return source.Replace(oldValue, newValue);
    }

    public string CustomSubstring(string source, int startIndex, int length)
    {
        if (startIndex < 0 || startIndex + length > source.Length)
        {
            Console.WriteLine("Invalid startIndex or length");
        }

        return source.Substring(startIndex, length);
    }

    public string CustomTrim(string source)
    {
        return source.Trim();
    }
    
}