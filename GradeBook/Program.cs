using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("shreyas's gradebook");
            book.GradeAdded += OngradeAdded;

            while (1 > 0)
            {
                Console.WriteLine("Enter value between 1 & 100");
                var input = Console.ReadLine();
                if (input == "Q" || input == "q")
                {
                    break;
                }
                else
                {
                    try
                    {
                        var value = double.Parse(input);
                        book.AddGrade(value);
                    }
                    catch(FormatException FeX)
                    {
                        Console.WriteLine(FeX.Message);
                    }
                }

            }
            var stats =  book.GetStatistics();

            Console.WriteLine($"This is {book.Name}");
            Console.WriteLine($"The Highes grade is {stats.High:N2}!");
            Console.WriteLine($"The Lowest grade is {stats.Low}!");
            Console.WriteLine($"The average grade is {stats.Average}!");
            Console.WriteLine($"Letter Grade is {stats.Letter}!");
            Console.ReadKey();

        }

        static void OngradeAdded(object sender , EventArgs args)
        {
            Console.WriteLine("Grade added");
        }
    }
}
