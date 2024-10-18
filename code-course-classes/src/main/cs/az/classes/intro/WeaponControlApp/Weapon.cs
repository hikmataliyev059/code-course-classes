namespace code_course_classes.main.cs.az.classes.intro.WeaponControlApp;

public class Weapon
{
    private int bullet_Capacity;
    private int current_Bullets;
    public bool isAutomatic;

    public int Bullet_Capacity
    {
        get => bullet_Capacity;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Bullet capacity cannot be negative.");
            }
            else
            {
                bullet_Capacity = value;

                if (current_Bullets > bullet_Capacity)
                {
                    current_Bullets = bullet_Capacity;
                }
            }
        }
    }

    public int Current_Bullets
    {
        get => current_Bullets;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Bullet count cannot be negative.");
            }
            else if (value > bullet_Capacity)
            {
                Console.WriteLine(
                    $"Bullet count cannot exceed capacity ({bullet_Capacity}). Please enter a valid bullet count.");
                while (value > bullet_Capacity)
                {
                    Console.WriteLine($"The magazine capacity is {bullet_Capacity}, please enter a valid count:");
                    value = int.Parse(Console.ReadLine());
                }

                current_Bullets = value;
            }
            else
            {
                current_Bullets = value;
            }
        }
    }

    public bool IsAutomatic
    {
        get => isAutomatic;
        set => isAutomatic = value;
    }

    public Weapon(int bulletCapacity, int currentBullets, bool isAutomatic)
    {
        bullet_Capacity = bulletCapacity;
        current_Bullets = currentBullets;
        this.isAutomatic = isAutomatic;
    }

    public void Shoot()
    {
        if (current_Bullets == 0)
        {
            Console.WriteLine("No bullets in the magazine!");
        }
        else if (isAutomatic)
        {
            Console.WriteLine($"Automatic fire: {current_Bullets} bullets were fired.");
            current_Bullets = 0;
        }
        else
        {
            current_Bullets--;
            Console.WriteLine($"Single fire: 1 bullet fired, remaining bullets: {current_Bullets}");
        }
    }

    public int GetRemainBulletCount()
    {
        return bullet_Capacity - current_Bullets;
    }

    public void Reload()
    {
        int neededBullets = GetRemainBulletCount();
        current_Bullets = bullet_Capacity;
        Console.WriteLine($"Magazine reloaded. {neededBullets} bullets added.");
    }

    public void ChangeFireMode()
    {
        isAutomatic = !isAutomatic;
        string mode = isAutomatic ? "Automatic" : "Single fire";
        Console.WriteLine($"Fire mode changed to: {mode}");
    }
    
}