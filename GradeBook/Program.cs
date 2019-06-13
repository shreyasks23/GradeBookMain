using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            IBook diskBook = new DiskBook("Shrey's Grade book");
            EnterGrade(diskBook);





            //Inmemory book definition
            //IBook book = new InMemoryBook("shreyas's gradebook");
            //book.GradeAdded += OngradeAdded;
            //EnterGrade(book);
            var stats = diskBook.GetStatistics();

            Console.WriteLine($"This is {diskBook.Name}");
            Console.WriteLine($"The Highes grade is {stats.High:N2}!");
            Console.WriteLine($"The Lowest grade is {stats.Low}!");
            Console.WriteLine($"The average grade is {stats.Average}!");
            Console.WriteLine($"Letter Grade is {stats.Letter}!");
            Console.ReadKey();

        }

        private static void EnterGrade(IBook book)
        {
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
                    catch (FormatException FeX)
                    {
                        Console.WriteLine(FeX.Message);
                    }
                }

            }
        }

        static void OngradeAdded(object sender , EventArgs args)
        {
            Console.WriteLine("Grade added");
        }
    }
}
