using System;
using Xunit;
using DebuggingMonitoringTestingConsoleApp;

namespace DebuggingMonitoringTestingConsoleAppTest
{
    public class CalcUnitTest
    {
        [Fact]
        public void TestAdding2And2()
        {
            // Arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new Calc();

            // Act
            double actual = calc.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding2And3()
        {
            // Arrange
            double a = 2;
            double b = 3;
            double expected = 4;
            var calc = new Calc();

            // Act
            double actual = calc.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
