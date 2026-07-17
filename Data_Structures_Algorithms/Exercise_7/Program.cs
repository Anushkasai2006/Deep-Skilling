using System;

class Program
{
    static void Main(string[] args)
    {
        double currentValue = 10000;
        double growthRate = 0.10;
        int years = 5;

        FinancialForecast.DisplayForecast(currentValue, growthRate, years);
    }
}