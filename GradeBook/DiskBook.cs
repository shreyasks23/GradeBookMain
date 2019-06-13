using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GradeBook
{
    public class DiskBook : Book, IBook
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double Grade)
        {
            using (var Writer = File.AppendText($"{Name}.txt"))
            {
                if (Grade <= 100 && Grade >= 0)
                {
                    Writer.WriteLine(Grade);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                if(GradeAdded !=null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            using (var Reader = File.OpenText($"{Name}.txt"))
            {

                var line = Reader.ReadLine();
                while(line!=null)
                {
                    result.AddNumber(double.Parse(line));
                    line = Reader.ReadLine();
                }
                
            }

                return result;
        }
    }
}
