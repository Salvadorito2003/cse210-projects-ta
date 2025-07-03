using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        string userImput = "";
        int sum = 0;
        int largestNumber = 0;
        int smallestPositiveNumber = 100000000;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userImput != "0")
        {
            Console.Write("Enter Number: ");
            userImput = Console.ReadLine();
            float givenNumber = float.Parse(userImput);
            if (userImput != "0")
                numbers.Add(givenNumber);
        }
        ;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            if (number > 0 && number < smallestPositiveNumber)
            {
                smallestPositiveNumber = number;
            }
        }
        List<float> sortedNumbers = numbers;
        sortedNumbers.Sort();
        double average = numbers.Average();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine("Sorted list:");
        foreach (float number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}