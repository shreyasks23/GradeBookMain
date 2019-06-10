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
            book.AddGrade(22.55);
            book.AddGrade(32.67);
            book.AddGrade(42.54);



            //act
            var result = book.GetStatistics();



            //assert
            Assert.Equal(32.6 , result.Average , 1);
            Assert.Equal(42.54, result.High);
            Assert.Equal(22.55, result.Low);
        }
    }
}
