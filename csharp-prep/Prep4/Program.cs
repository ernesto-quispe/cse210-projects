using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
           Console.Write("Enter number: "); 
           number = int.Parse(Console.ReadLine());
           if (number != 0)
           {
             numbers.Add(number);
           }           
        }

        double total = numbers.Sum();
        double average  = total / numbers.Count;
        double largest = numbers.Max();
        double smallestPositive = numbers.Where(x => x > 0).Min();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is: ");

        numbers.Sort();

        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }

    }
}