using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("shreyas's gradebook");
            book.AddGrade(9.22);
            book.AddGrade(10.39);
            book.AddGrade(6.32);
            book.AddGrade(2.04);
            book.AddGrade(08.05);
            book.AddGrade(6.09);
            var stats =  book.GetStatistics();

            Console.WriteLine($"The Highes grade is {stats.High:N2}!");
            Console.WriteLine($"The Lowest grade is {stats.Low}!");
            Console.WriteLine($"The average grade is {stats.Average}!");

        }
    }
}
