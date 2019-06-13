using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class InMemoryBook : Book , IBook
    {
        List<double> grades;

        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            base.Name = name;
        }


        public override void AddGrade(Double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
                Console.WriteLine("invalid value");
        }

        public override event GradeAddedDelegate GradeAdded;




        public override Statistics GetStatistics()
        {
            var result = new Statistics();            

            for (var index = 0; index < grades.Count; index++)
            {
                result.AddNumber(grades[index]);
            }            
            return result;
        }

    }
}
