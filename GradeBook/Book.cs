using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{

    public delegate void GradeAddedDelegate(object sender , EventArgs args);



    public class Book
    {
        List<double> grades;
        public string Name { get; set; }



        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }


        public void AddGrade(Double grade)
        {
            if (grade <= 100 && grade >= 0)
                grades.Add(grade);

            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
            else
                Console.WriteLine("invalid value");
        }

        public event GradeAddedDelegate GradeAdded;




        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for (var index = 0; index < grades.Count; index++)
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
            }
            result.Average /= grades.Count;

            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                case var d when d >= 50.0:
                    result.Letter = 'E';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }
            return result;
        }


    }
}
