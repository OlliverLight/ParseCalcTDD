using System;
using Xunit;
using ParseCalcTDD;

namespace ParseCalcTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 7, 12)]
        [InlineData(20, 4.36, 24.36)]
        [InlineData(double.MaxValue, 1, double.MaxValue)]
        public void Addition_Simple_Numbers(double x, double y, double expected)
        {
            double actual = Program.Add(x, y);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(9, 3, 6)]
        [InlineData(37, 3.8, 33.2)]
        [InlineData(double.MinValue, 5, double.MinValue)]
        public void Subtraction_Simple_Numbers(double x, double y, double expected)
        {
            double actual = Program.Sub(x, y);
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(3,5,15)]
        [InlineData(3.5,23.6, 82.60000000000001)]
        public void Multiply_Simple_Numbers(double x, double y, double expected)
        {
            double actual = Program.Mult(x, y);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(55, 27.5, 2 )]
        public void Divide_Simple_Number(double x, double y, double expected)
        {
            double actual = Program.Div(x, y);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Devide_ByZero()
        {
            double expected = 0;
            double actual = Program.Div(20,0);
            Assert.Equal(expected, actual);
        }

    }
}
