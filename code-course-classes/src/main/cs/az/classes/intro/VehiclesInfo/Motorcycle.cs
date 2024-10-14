namespace code_course_classes.main.cs.az.classes.intro.VehiclesInfo;

public class Motorcycle : Vehicle
{
    public int WheelNum;

    public Motorcycle(string brand, string model, int wheelNum) : base(brand, model)
    {
        WheelNum = wheelNum;
    }
    
    public void ShowFullInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Wheels: {WheelNum}, Mile: {Mile}");
    }
    
}