using Stride.Core.Mathematics;

class Program
{
    static void Main()
    {
        // Create a Vector3
        Vector3 vector = new Vector3(1, 2, 3);

        // Perform some operations
        Vector3 scaledVector = vector * 2;
        Vector3 translatedVector = vector + new Vector3(1, 1, 1);

        // Print the results
        Console.WriteLine($"Scaled vector: {scaledVector}");
        Console.WriteLine($"Translated vector: {translatedVector}");
    }
}
