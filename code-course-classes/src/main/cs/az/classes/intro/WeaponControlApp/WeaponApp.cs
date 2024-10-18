namespace code_course_classes.main.cs.az.classes.intro.WeaponControlApp;

public class WeaponApp
{
    
    public static void Main(string[] args)
    {
        Console.Write("Magazine capacity: ");
        int bulletCapacity = int.Parse(Console.ReadLine());
        Console.Write("Bullets in the magazine: ");
        int currentBullets = int.Parse(Console.ReadLine());
        Console.Write("Fire mode (enter '0' for single fire, '1' for automatic): ");
        bool isAutomatic = Console.ReadLine() == "1";

        Weapon weapon = new Weapon(bulletCapacity, currentBullets, isAutomatic);
        while (true)
        {
            Console.WriteLine("\nSelect the desired command:");
            Console.WriteLine("0 - Get information");
            Console.WriteLine("1 - For Shoot method");
            Console.WriteLine("2 - For GetRemainBulletCount method");
            Console.WriteLine("3 - For Reload method");
            Console.WriteLine("4 - For ChangeFireMode method");
            Console.WriteLine("5 - To exit the program");
            Console.WriteLine("6 - Modify settings");

            int command = int.Parse(Console.ReadLine());

            switch (command)
            {
                case 0:
                    Console.WriteLine(
                        $"Magazine capacity: {weapon.Bullet_Capacity}, Current bullet count: {weapon.Current_Bullets}, Fire mode: {(weapon.isAutomatic ? "Automatic" : "Single fire")}");
                    break;
                case 1:
                    weapon.Shoot();
                    break;
                case 2:
                    Console.WriteLine($"Bullets needed to fill the magazine: {weapon.GetRemainBulletCount()}");
                    break;
                case 3:
                    weapon.Reload();
                    break;
                case 4:
                    weapon.ChangeFireMode();
                    break;
                case 5:
                    Console.WriteLine("Exiting the program...");
                    return;
                case 6:
                    Console.WriteLine("Modify magazine capacity or bullet count:");
                    Console.WriteLine("7 - Change magazine capacity");
                    Console.WriteLine("8 - Change current bullet count");
                    Console.WriteLine("9 - Go back to main menu");

                    int subCommand = int.Parse(Console.ReadLine());

                    switch (subCommand)
                    {
                        case 7:
                            Console.WriteLine("Enter the new magazine capacity:");
                            int newCapacity = int.Parse(Console.ReadLine());
                            weapon.Bullet_Capacity = newCapacity;
                            Console.WriteLine($"New magazine capacity: {weapon.Bullet_Capacity}");
                            break;
                        case 8:
                            Console.WriteLine("Enter the new bullet count:");
                            int newBullets = int.Parse(Console.ReadLine());
                            weapon.Current_Bullets = newBullets;
                            Console.WriteLine($"New bullet count: {weapon.Current_Bullets}");
                            break;
                        case 9:
                            Console.WriteLine("Returning to main menu.");
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
    
}