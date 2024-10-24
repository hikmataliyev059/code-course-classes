namespace code_course_classes.main.cs.az.classes.intro.ProductCatalog.cs;

public class Store
{
    
    Product?[] products = new Product?[0];

    public void AddProduct(Product? product)
    {
        Array.Resize(ref products, products.Length + 1);
        products[^1] = product;
    }

    public Product[] RemoveProduct(int number)
    {
        Product[] product = new Product[products.Length - 1];
        int index = 0;
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].No1 != number)
            {
                products[index] = products[i];
                index++;
            }
        }

        products = product;
        return product;
    }


    public Product GetProduct(int? no)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i]?.No1 == no)
            {
                return products[i];
            }
        }

        return null;
    }

    public Product[] FilterProductsByType(Type? type)
    {
        Product[] types = new Product[0];
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i]?.type == type)
            {
                Array.Resize(ref types, types.Length + 1);
                types[^1] = products[i];
            }
        }

        return types;
    }

    public Product[] FilterProductByName(string? name)
    {
        Product[] names = new Product[0];
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i]?.Name == name)
            {
                Array.Resize(ref names, names.Length + 1);
                names[^1] = products[i];
            }
        }

        return names;
    }
    
}