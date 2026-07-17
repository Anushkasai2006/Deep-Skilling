using System;

class FinancialForecast
{
    public static void DisplayForecast(double currentValue, double growthRate, int years)
    {
        double futureValue = ForecastCalculator.CalculateFutureValue(currentValue, growthRate, years);

        Console.WriteLine("Financial Forecast");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Current Value : " + currentValue);
        Console.WriteLine("Growth Rate   : " + (growthRate * 100) + "%");
        Console.WriteLine("Years         : " + years);
        Console.WriteLine("Future Value  : " + futureValue.ToString("F2"));

        Console.WriteLine();
        Console.WriteLine("Time Complexity : O(n)");
        Console.WriteLine("Space Complexity: O(n)");
        Console.WriteLine();
        Console.WriteLine("Optimization:");
        Console.WriteLine("Memoization or an iterative approach can reduce recursion overhead.");
    }
}