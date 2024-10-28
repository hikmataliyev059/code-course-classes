using code_course_classes.main.cs.az.classes.core.HotelManagementSystem.Models;

namespace code_course_classes.main.cs.az.classes.core.HotelManagementSystem;

public class HotelManagementApp
{
    
    private static List<Hotel> Hotels = new List<Hotel>();

    public static void Main(string[] args)
    {
        int mainChoice;
        do
        {
            Console.WriteLine("****** Menu ******");
            Console.WriteLine("1. Login to System");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            mainChoice = int.Parse(Console.ReadLine());

            if (mainChoice == 1)
            {
                HotelMenu();
            }
        } while (mainChoice != 0);
    }

    static void HotelMenu()
    {
        int hotelChoice;
        do
        {
            Console.WriteLine("****** Hotel Menu ******");
            Console.WriteLine("1. Create Hotel");
            Console.WriteLine("2. View All Hotels");
            Console.WriteLine("3. Select Hotel");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            hotelChoice = int.Parse(Console.ReadLine());

            switch (hotelChoice)
            {
                case 1:
                    CreateHotel();
                    break;
                case 2:
                    ViewAllHotels();
                    break;
                case 3:
                    SelectHotel();
                    break;
            }
        } while (hotelChoice != 0);
    }

    static void CreateHotel()
    {
        Console.Write("Enter hotel name: ");
        string name = Console.ReadLine();

        if (Hotels.Exists(h => h.Name == name))
        {
            Console.WriteLine("A hotel with this name already exists.");
        }
        else
        {
            Hotels.Add(new Hotel(name));
            Console.WriteLine($"Hotel '{name}' has been created.");
        }
    }

    static void ViewAllHotels()
    {
        if (Hotels.Count == 0)
        {
            Console.WriteLine("There are no hotels in the system.");
        }
        else
        {
            Console.WriteLine("Hotels:");
            Hotels.ForEach(h => Console.WriteLine($"- {h.Name}"));
        }
    }

    static void SelectHotel()
    {
        Console.Write("Enter hotel name: ");
        string name = Console.ReadLine();
        Hotel selectedHotel = Hotels.Find(h => h.Name == name);

        if (selectedHotel == null)
        {
            Console.WriteLine("No hotel found with this name.");
        }
        else
        {
            RoomMenu(selectedHotel);
        }
    }

    static void RoomMenu(Hotel hotel)
    {
        int roomChoice;
        do
        {
            Console.WriteLine("****** Room Menu ******");
            Console.WriteLine("1. Create Room");
            Console.WriteLine("2. View Rooms");
            Console.WriteLine("3. Make Reservation");
            Console.WriteLine("4. Return to Previous Menu");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            roomChoice = int.Parse(Console.ReadLine());

            switch (roomChoice)
            {
                case 1:
                    hotel.CreateRoom();
                    break;
                case 2:
                    hotel.ViewRooms();
                    break;
                case 3:
                    hotel.MakeReservation();
                    break;
            }
        } while (roomChoice != 0 && roomChoice != 4);
    }
    
}