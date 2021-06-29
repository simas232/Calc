using Xunit;

namespace Calc.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_OneSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35 };
            double expected = double.NaN;
            double result;

            //Act
            result = Calculator.Add(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Add_ThreeSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2 };
            double expected = testNumbers[0] + testNumbers[1] + testNumbers[2];
            double result;

            //Act
            result = Calculator.Add(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Add_NineSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2, -2.3, 5, 99.2, 74.3, 500.14, -111.92 };
            double expected = testNumbers[0] + testNumbers[1] + testNumbers[2] +
                testNumbers[3] + testNumbers[4] + testNumbers[5] +
                testNumbers[6] + testNumbers[7] + testNumbers[8];
            double result;

            //Act
            result = Calculator.Add(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Subtract_OneSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35 };
            double expected = double.NaN;
            double result;

            //Act
            result = Calculator.Subtract(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Subtract_ThreeSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2 };
            double expected = testNumbers[0] - testNumbers[1] - testNumbers[2];
            double result;

            //Act
            result = Calculator.Subtract(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Subtract_NineSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2, -2.3, 5, 99.2, 74.3, 500.14, -111.92 };
            double expected = testNumbers[0] - testNumbers[1] - testNumbers[2] -
                testNumbers[3] - testNumbers[4] - testNumbers[5] -
                testNumbers[6] - testNumbers[7] - testNumbers[8];
            double result;

            //Act
            result = Calculator.Subtract(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Multiply_OneSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35 };
            double expected = double.NaN;
            double result;

            //Act
            result = Calculator.Multiply(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Multiply_ThreeSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2 };
            double expected = testNumbers[0] * testNumbers[1] * testNumbers[2];
            double result;

            //Act
            result = Calculator.Multiply(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Multiply_NineSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2, -2.3, 5, 99.2, 74.3, 500.14, -111.92 };
            double expected = testNumbers[0] * testNumbers[1] * testNumbers[2] *
                testNumbers[3] * testNumbers[4] * testNumbers[5] *
                testNumbers[6] * testNumbers[7] * testNumbers[8];
            double result;

            //Act
            result = Calculator.Multiply(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Divide_OneSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35 };
            double expected = double.NaN;
            double result;

            //Act
            result = Calculator.Divide(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Divide_ThreeSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2 };
            double expected = testNumbers[0] / testNumbers[1] / testNumbers[2];
            double result;

            //Act
            result = Calculator.Divide(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Divide_NineSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2, -2.3, 5, 99.2, 74.3, 500.14, -111.92 };
            double expected = testNumbers[0] / testNumbers[1] / testNumbers[2] /
                testNumbers[3] / testNumbers[4] / testNumbers[5] /
                testNumbers[6] / testNumbers[7] / testNumbers[8];
            double result;

            //Act
            result = Calculator.Divide(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Divide_ByZeroThreeSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35, -8.95, 0 };
            double expected = double.NaN;
            double result;

            //Act
            result = Calculator.Divide(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Divide_ByZeroNineSizedArrayTest()
        {
            //Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2, -2.3, 5, 99.2, 74.3, 500.14, 0 };
            double expected = double.NaN;
            double result;

            //Act
            result = Calculator.Divide(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }

    }
}
