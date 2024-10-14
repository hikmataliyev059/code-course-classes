namespace code_course_classes.main.cs.az.classes.intro.ProductCatalog;

public class Product
{
    public string Name;
    public string Description;
    public int Count;
    public double Price;
    public bool IsStock => Count > 0;

    public Product(string name, int count, double price)
    {
        Name = name;
        Count = count;
        Price = price < 0 ? 0 : price;
    }

    public void Sale()
    {
        if (!IsStock)
        {
            Console.WriteLine("Product is out of stock: " + Name);
            return;
        }

        Count--;
        Console.WriteLine("Product sold: " + Name + ", Now " + Count + " left in stock.");
        
        if (!IsStock)
        {
            Console.WriteLine("Product is out of stock: " + Name);
        }
    }

    public string GetFullInfo()
    {
        string fullInfo =
            "Product Information:\n" +
            "Name: " + Name + "\n" +
            "Description: " + (Description != null && Description.Length > 0 ? Description : "No description.") + "\n" +
            "Count: " + Count + "\n" +
            "Price: " + Price;

        return fullInfo;
    }

    public void ShowFullData()
    {
        Console.WriteLine(GetFullInfo());
    }
    
}