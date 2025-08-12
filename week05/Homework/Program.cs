using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment1 = new MathAssignment("Samuel Bennet", "Multiplication", "Section 7.3", "Problems 8-19");
        string summary = mathAssignment1.GetSummary();
        string homeworkList = mathAssignment1.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(homeworkList);

        WritingAssingment writingAssingment1 = new WritingAssingment("Mary Waters", "European History", "The Causes of World War II");
        string writingSummary = writingAssingment1.GetSummary();
        string writingInfo = writingAssingment1.GetWritingInformation();
        Console.WriteLine(writingSummary);
        Console.WriteLine(writingInfo);

    }
}