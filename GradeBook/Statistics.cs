using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class Statistics
    {
        public double Average { get
            {
                return Sum / Count;
            }
        }
        public double High { get; set; }
        public double Low { get; set; }

        public char Letter { get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';
                    case var d when d >= 80.0:
                        return 'B';
                    case var d when d >= 70.0:
                        return 'C';                        
                    case var d when d >= 60.0:
                        return 'D';
                    case var d when d >= 50.0:
                        return 'E';
                    default:
                        return 'F';
                }
            }
        }

        public double Sum { get; set; }

        public int Count { get; set; }

        public Statistics()
        {
            Sum = 0;
            Count = 0;
            High = double.MinValue;
            Low = double.MaxValue;            
        }

        public void AddNumber(double number)
        {
            Sum += number;
            Count++;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
            
        }

        public double ComputeAverage(double value)
        {
            var result = 0.00;
            result += value;


            return result;
        }

        public char ComputeLetterGrade(double average)
        {
            char ltr; 
            switch (average)
            {
                case var d when d >= 90.0:
                    ltr = 'A';
                    break;
                case var d when d >= 80.0:
                    ltr = 'B';
                    break;
                case var d when d >= 70.0:
                    ltr = 'C';
                    break;
                case var d when d >= 60.0:
                    ltr = 'D';
                    break;
                case var d when d >= 50.0:
                    ltr = 'E';
                    break;
                default:
                    ltr = 'F';
                    break;
            }
            return ltr;
        }
    }
}
