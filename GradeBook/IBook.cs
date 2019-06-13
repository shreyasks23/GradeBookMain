using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    interface IBook
    {
        void AddGrade(double Grade);
        Statistics GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }
}
