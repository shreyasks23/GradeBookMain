using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class Book
    {
        List<double> grades;
        public string Name;
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(Double grade)
        {
            grades.Add(grade);
        }       
        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.High= double.MinValue;
            result.Low = double.MaxValue;
            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low =  Math.Min(grade, result.Low);
                result.Average += grade;
                
            }
            result.Average /= grades.Count;
            return result;
        }
    }
}
