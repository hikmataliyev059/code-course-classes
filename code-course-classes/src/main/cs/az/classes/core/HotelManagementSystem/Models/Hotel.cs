namespace code_course_classes.main.cs.az.classes.core.HotelManagementSystem.Models;

public class Hotel
{
    
    public string Name { get; set; }
    public int id { get; set; }
    private List<Room> Rooms { get; set; } = new List<Room>();

    public Hotel(string name)
    {
        Name = name;
    }

    public void CreateRoom()
    {
        Console.Write("Enter room name: ");
        string name = Console.ReadLine();
        Console.Write("Enter room price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Enter room capacity: ");
        int capacity = int.Parse(Console.ReadLine());

        Rooms.Add(new Room(name, price, capacity));
        Console.WriteLine($"Room '{name}' has been created.");
    }

    public void ViewRooms()
    {
        if (Rooms.Count == 0)
        {
            Console.WriteLine("There are no rooms in this hotel.");
        }
        else
        {
            Console.WriteLine("Rooms:");
            Rooms.ForEach(r => Console.WriteLine(r.ShowInfo()));
        }
    }

    public void MakeReservation()
    {
        if (Rooms.Count == 0)
        {
            Console.WriteLine("There are no available rooms for reservation in this hotel.");
            return;
        }

        Console.Write("Enter the ID of the room you'd like to reserve: ");
        int roomId = int.Parse(Console.ReadLine());
        Room room = Rooms.Find(r => r.Id == roomId);

        if (room == null)
        {
            Console.WriteLine("Room not found.");
        }
        else if (!room.IsAvailable)
        {
            Console.WriteLine("This room has already been reserved.");
        }
        else
        {
            room.IsAvailable = false;
            Console.WriteLine("Reservation completed successfully.");
        }
    }
    
}