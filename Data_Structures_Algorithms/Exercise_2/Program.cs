using System;

class Program
{
    static void Main(string[] args)
    {
        Product[] products =
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Mobile", "Electronics"),
            new Product(103, "Shoes", "Fashion"),
            new Product(104, "Watch", "Accessories"),
            new Product(105, "Bag", "Fashion")
        };

        int searchId = 104;

        Console.WriteLine("----- Linear Search -----");

        Product linearResult = SearchAlgorithms.LinearSearch(products, searchId);

        if (linearResult != null)
        {
            Console.WriteLine($"Product ID   : {linearResult.ProductId}");
            Console.WriteLine($"Product Name : {linearResult.ProductName}");
            Console.WriteLine($"Category     : {linearResult.Category}");
        }

        Console.WriteLine();

        Console.WriteLine("----- Binary Search -----");

        Product binaryResult = SearchAlgorithms.BinarySearch(products, searchId);

        if (binaryResult != null)
        {
            Console.WriteLine($"Product ID   : {binaryResult.ProductId}");
            Console.WriteLine($"Product Name : {binaryResult.ProductName}");
            Console.WriteLine($"Category     : {binaryResult.Category}");
        }

        Console.WriteLine();
        Console.WriteLine("Time Complexity");
        Console.WriteLine("Linear Search : O(n)");
        Console.WriteLine("Binary Search : O(log n)");

        Console.WriteLine();
        Console.WriteLine("Binary Search is faster for sorted data because it divides the search space into half in every iteration.");
    }
}