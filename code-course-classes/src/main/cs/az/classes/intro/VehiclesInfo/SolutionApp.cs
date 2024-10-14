namespace code_course_classes.main.cs.az.classes.intro.VehiclesInfo;

public class SolutionApp
{
    public static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Camry", 4);
        myCar.Mile = 20000;
        myCar.ShowFullInfo();

        Motorcycle myMotorcycle = new Motorcycle("BMW", "M5", 2);
        myMotorcycle.Mile = 5000;
        myMotorcycle.ShowFullInfo();
    }
    
}