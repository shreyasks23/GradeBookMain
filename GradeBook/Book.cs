﻿using System;
using System.Text;

namespace GradeBook
{

    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
            base.Name = name;
        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
    }
}
