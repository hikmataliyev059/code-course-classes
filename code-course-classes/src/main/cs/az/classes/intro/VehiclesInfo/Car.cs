namespace code_course_classes.main.cs.az.classes.intro.VehiclesInfo;

public class Car : Vehicle
{
    public int DoorsNum;

    public Car(string brand, string model, int doorsNum) : base(brand, model)
    {
        DoorsNum = doorsNum;
    }
    
    public void ShowFullInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Doors: {DoorsNum}, Mile: {Mile}");
    }
    
}