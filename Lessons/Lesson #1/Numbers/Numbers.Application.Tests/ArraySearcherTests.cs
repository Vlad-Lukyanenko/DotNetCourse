using System.Collections.Generic;
using Numbers.Application.Exceptions;
using Xunit;

namespace Numbers.Application.Tests
{
    public class ArraySearcherTests
    {
        [Fact]
        public void Find_Min_Value_Test()
        {
            var numbers = new List<int> { 6, 3, -1, 0, 32, 21, -34, 43 };
            var arraySearcher = new ArraySearcher(numbers);

            const int expectedResult = -34;
            var actualResult = arraySearcher.GetMinimum();

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Find_Max_Value_Test()
        {
            var numbers = new List<int> { 6, 3, -1, 0, 32, 21, -34, 43 };
            var arraySearcher = new ArraySearcher(numbers);

            const int expectedResult = 43;
            var actualResult = arraySearcher.GetMaximum();

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Null_Value_Array_Test()
        {
            Assert.Throws<NullArrayException>(() => new ArraySearcher(null));
        }

        [Fact]
        public void Empty_Array_Test()
        {
            Assert.Throws<EmptyArrayException>(() => new ArraySearcher(new List<int>()));
        }
    }
}
