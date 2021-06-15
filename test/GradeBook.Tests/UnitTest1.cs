using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        // Fact is an attribute - piece of data attached to the method test1
        [Fact]
        public void Test1()
        {
            // arrange
            var x = 5;
            var y = 2;
            var expected = 7;

            // act
            var actual = x * y;
            
            // assert
            Assert.Equal(expected, actual);
        }

    }
}
