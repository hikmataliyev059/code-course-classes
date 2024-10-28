namespace code_course_classes.main.cs.az.classes.core.HotelManagementSystem.Helpers.Exceptions;

public class NotAvailableException : Exception
{
    public NotAvailableException(string? message) : base(message)
    {
    }
}