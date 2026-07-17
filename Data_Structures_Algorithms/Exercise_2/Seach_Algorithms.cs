using System;

class SearchAlgorithms
{
    // Linear Search
    public static Product LinearSearch(Product[] products, int searchId)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == searchId)
            {
                return product;
            }
        }

        return null;
    }

    // Binary Search
    public static Product BinarySearch(Product[] products, int searchId)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == searchId)
                return products[mid];

            if (products[mid].ProductId < searchId)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }
}