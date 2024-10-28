namespace code_course_classes.main.cs.az.classes.core.HotelManagementSystem.Models;

public class Room
{
    
    private static int _noCounter;
    public int Id { get; }
    private string _name;
    public double _price;
    public int _personCapacity;
    public bool IsAvailable { get; set; } = true;

    public Room(string name, double price, int personCapacity)
    {
        Id = ++_noCounter;
        _name = name;
        _price = price;
        _personCapacity = personCapacity;
    }

    public string ShowInfo()
    {
        return $"Name: {_name}, Price: {_price}, Capacity: {_personCapacity}";
    }

    public override string ToString()
    {
        return ShowInfo();
    }
    
}