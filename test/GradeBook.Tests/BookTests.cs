using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        // Fact is an attribute - piece of data attached to the method test1
        [Fact]
        public void BookCalculatesAverageGrades()
        {
            // arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();


            // assert
            Assert.Equal(85.6, result.Average);
            Assert.Equal(90.5, result.High);
            Assert.Equal(77.3, result.Low);
            Assert.Equal('B', result.Letter);
        }

    }
}
