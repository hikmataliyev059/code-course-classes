namespace code_course_classes.main.cs.az.classes.intro.ProductCatalog.cs;

public class StoreConsoleApp
{
    public static void Main(string[] args)
    {
        Store store = new Store();
        bool continueProgram = true;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Filter Products by Type");
            Console.WriteLine("3. Filter Products by Name");
            Console.WriteLine("4. Remove Product");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct(store);
                    break;

                case "2":
                    FilterProductsByType(store);
                    break;

                case "3":
                    FilterProductsByName(store);
                    break;

                case "4":
                    RemoveProduct(store);
                    break;

                case "5":
                    continueProgram = false;
                    Console.WriteLine("Exiting program.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        } while (continueProgram);
    }

    public static void AddProduct(Store store)
    {
        try
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select Product Type:");
            foreach (var type in Enum.GetValues(typeof(Type)))
            {
                Console.WriteLine($"{(int)type} - {type}");
            }

            Type productType = (Type)Enum.Parse(typeof(Type), Console.ReadLine());

            Product product = new Product(name, price, productType);
            store.AddProduct(product);
            Console.WriteLine("Product added successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static void FilterProductsByType(Store store)
    {
        Console.WriteLine("Select Type to filter:");
        foreach (var type in Enum.GetValues(typeof(Type)))
        {
            Console.WriteLine($"{(int)type} - {type}");
        }

        Type filterType = (Type)Enum.Parse(typeof(Type), Console.ReadLine());

        Product[] filteredProducts = store.FilterProductsByType(filterType);
        Console.WriteLine("Filtered Products:");
        foreach (var product in filteredProducts)
        {
            Console.WriteLine($"No: {product.No1}, Name: {product.Name}, Price: {product.Price}, Type: {product.type}");
        }
    }

    public static void FilterProductsByName(Store store)
    {
        Console.Write("Enter the name to filter by: ");
        string name = Console.ReadLine();

        Product[] filteredProducts = store.FilterProductByName(name);
        Console.WriteLine("Filtered Products:");
        foreach (var product in filteredProducts)
        {
            Console.WriteLine($"No: {product.No1}, Name: {product.Name}, Price: {product.Price}, Type: {product.type}");
        }
    }

    public static void RemoveProduct(Store store)
    {
        Console.Write("Enter the product number to remove: ");
        int number = Convert.ToInt32(Console.ReadLine());

        store.RemoveProduct(number);
        Console.WriteLine("Product removed successfully.");
    }
}