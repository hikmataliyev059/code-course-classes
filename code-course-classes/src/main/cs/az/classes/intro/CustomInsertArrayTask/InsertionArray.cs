namespace code_course_classes.main.cs.az.classes.intro.CustomInsertArrayTask;

public class InsertionArray
{
    
    public static void Main(string[] args)
    {
        int[] originalArray = { 1, 2, 3 };
        Console.Write("Original Array: ");
        PrintArray(originalArray);

        InsertArray(ref originalArray, 4, 5, 6);

        Console.Write("Updated Array: ");
        PrintArray(originalArray);
    }
    
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    static void InsertArray(ref int[] original, params int[] newValues)
    {
        int newSize = original.Length + newValues.Length;
        int[] updatedArray = new int[newSize];
        
        for (int i = 0; i < original.Length; i++)
        {
            updatedArray[i] = original[i];
        }
        
        for (int j = 0; j < newValues.Length; j++)
        {
            updatedArray[original.Length + j] = newValues[j];
        }
        
        original = updatedArray;
    }
    
}