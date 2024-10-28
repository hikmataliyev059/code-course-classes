using code_course_classes.main.cs.az.classes.core.HotelManagementSystem.Helpers.Exceptions;
using code_course_classes.main.cs.az.classes.core.HotelManagementSystem.Models;

namespace code_course_classes.main.cs.az.classes.core.HotelManagementSystem.Data;

public static class AppDbContext
{
    
    private static List<Room> Rooms = new List<Room>();
    
    public static void AddRoom(Room room)
    {
        Rooms.Add(room);
    }

    public static List<Room> FindAllRoom(double price)
    {
        return Rooms.FindAll(x => x._price == price);
    }

    public static void MakeReservation(int? roomId, int userId)
    {
        if (roomId == null)
        {
            throw new NullReferenceException("Room ID cannot be null.");
        }

        Room room = Rooms.Find(x => x.Id == roomId);


        if (room == null)
        {
            throw new NullReferenceException("This room has not been available.");
        }

        if (!room.IsAvailable)
        {
            throw new NotAvailableException("This room has already been reserved.");
        }

        if (userId > room._personCapacity)
        {
            throw new ArgumentException("The number of users exceeds the room capacity.");
        }

        room.IsAvailable = false;
    }
    
}