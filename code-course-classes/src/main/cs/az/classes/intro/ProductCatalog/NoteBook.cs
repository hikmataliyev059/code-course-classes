namespace code_course_classes.main.cs.az.classes.intro.ProductCatalog;

public class NoteBook : Product
{
    public byte RAM;
    public int Storage;

    public NoteBook(string name, int count, double price, byte ram, int storage)
        : base(name, count, price)
    {
        RAM = ram;
        Storage = storage;
    }

    public void ShowFullData()
    {
        base.ShowFullData();
        Console.WriteLine("RAM: " + RAM + " GB");
        Console.WriteLine("Storage: " + Storage + " GB");
    }
    
}