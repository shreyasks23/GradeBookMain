using System;
using Xunit;
using GradeBook;


namespace GradeBookTestProject
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesGrades()
        {
            //arrange
           var book = new Book("");
            book.AddGrade(82.55);
            book.AddGrade(92.67);
            book.AddGrade(82.54);
            book.AddGrade(85.0);



            //act
            var result = book.GetStatistics();



            //assert
            Assert.Equal('B', result.Letter);
        }
    }
}
