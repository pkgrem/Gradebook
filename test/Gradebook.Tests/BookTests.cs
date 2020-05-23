using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange objects
                var book = new Book("");
                book.AddGrade(93);
                book.AddGrade(2.3);
                book.AddGrade(44);

            // act

            var result = book.ShowStatistics();
               
            
            // assert what happens
            Assert.Equal(85.5,result.Average);
        }
    }
}
