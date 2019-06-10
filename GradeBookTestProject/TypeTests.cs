using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using GradeBook;

namespace GradeBookTestProject
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");
            var book3 = GetBook("Book3");

            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book2", book2.Name);
            Assert.Equal("Book3", book3.Name);

        }

        public Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
