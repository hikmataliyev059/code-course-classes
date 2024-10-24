namespace code_course_classes.main.cs.az.classes.intro.ProductCatalog.cs;

public class PriceMustBeGreatherThanZeroException : Exception
{
    public PriceMustBeGreatherThanZeroException(string? message) : base(message)
    {
    }
}