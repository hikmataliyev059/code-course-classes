namespace code_course_classes.main.cs.az.classes.intro.ProductCatalog;

public class SolutionApp
{
    
    public static void Main(string[] args)
    {
        NoteBook notebook = new NoteBook("Acer Aspire", 5, 599.99, 8, 512);
        notebook.Description = "Thin and lightweight notebook";
        
        notebook.Sale();
        
        notebook.ShowFullData();

        NoteBook outOfStockNotebook = new NoteBook("HP Pavilion", 0, 799.99, 16, 1024);
        outOfStockNotebook.Sale();
    }
    
}