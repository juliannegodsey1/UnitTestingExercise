using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-1, -1, -1, -3)]
        [InlineData(-2, 1, 1, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
           
            var calc = new Calculator();

            var actual = calc.Add(num1, num2, num3);

            Assert.Equal(expected, actual);
        }



        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(0, 1, -1)]
        [InlineData(-2, -1, -1)]

        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
           
            var calc = new Calculator();

            var actual = calc.Subtract(minuend, subtrhend);

            Assert.Equal(expected, actual);


        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 0, 0)]
        [InlineData(-1, -1, 1)]
        [InlineData(-1, 0, 0)]
        [InlineData(0, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            var calc = new Calculator();
            
            var actual = calc.Multiply(num1, num2);

            Assert.Equal(expected, actual);

        }


        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(1, 1, 1)]
        [InlineData(1, 0, 0)]
        [InlineData(-2, 1, -2)]
        [InlineData(-2, -1, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 0)]
        public void DivideTest(int dividend, int divisor, int expected)
        {
            var calc = new Calculator();
            var actual = calc.Divide(dividend, divisor);
            Assert.Equal(expected, actual);

        }

    }
}
