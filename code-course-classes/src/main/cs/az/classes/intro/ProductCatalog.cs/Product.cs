namespace code_course_classes.main.cs.az.classes.intro.ProductCatalog.cs;

public class Product
{
    private string _name;
    private int no;
    private static int _noCounter = 0;
    private double _price;
    public Type type;

    public Product(string name, double price, Type type)
    {
        _name = name;
        no = ++_noCounter;
        _price = price;
        this.type = type;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int No1
    {
        get => no;
        set => no = value;
    }

    public double Price
    {
        get => _price;
        set
        {
            if (value < 0)
            {
                throw new PriceMustBeGreatherThanZeroException("Price cannot be negative");
            }

            _price = value;
        }
    }
    
}