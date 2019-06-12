using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using GradeBook;

namespace GradeBookTestProject
{

    public delegate string GetBookName(string name);



    public class TypeTests
    {
        [Fact]
        public void DelegatePointToDifMethod()
        {
            GetBookName getBookName;

            getBookName = returnMessage;

            var result = getBookName("hi");
            Assert.Equal("hi", result);
        }


        string returnMessage(string msg)
        {
            return msg;
        }




        [Fact]
        public void GetBookReturnsDifferentObjects()
        {

            //Prepare
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");
            var book3 = GetBook("Book3");

            

            //Assert
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
