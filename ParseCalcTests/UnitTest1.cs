using System;
using Xunit;
using ParseCalcTDD;

namespace ParseCalcTests
{
    public class UnitTest1
    {
        [Fact]
        public void SimpleNumber()
        {
            Assert.Equal(6.0, Program.Interperate("6"));

        }
        [Fact]
        public void Addition()
        {
            Assert.Equal(6.0, Program.Interperate("3+3"));

        }
        [Fact]
        public void Subtraction()
        {
            Assert.Equal(6.0, Program.Interperate("9-3"));

        }
    }
}
