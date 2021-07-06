using Xunit;

namespace Calc.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(3, 5)]
        [InlineData(8.4, -7.55)]
        [InlineData(-2, 88.92)]
        public void Add_TwoNumberCalcWorks(double firstNumber, double secondNumber)
        {
            // Arrange
            double expectedResult = firstNumber + secondNumber;
            double actualResult;

            // Act
            actualResult = Calculator.Add(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Theory]
        [InlineData(3, 5)]
        [InlineData(8.4, -7.55)]
        [InlineData(-2, 88.92)]
        public void Subtract_TwoNumberCalcWorks(double firstNumber, double secondNumber)
        {
            // Arrange
            double expectedResult = firstNumber - secondNumber;
            double actualResult;

            // Act
            actualResult = Calculator.Subtract(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Theory]
        [InlineData(3, 5)]
        [InlineData(8.4, -7.55)]
        [InlineData(-2, 88.92)]
        public void Multiply_TwoNumberCalcWorks(double firstNumber, double secondNumber)
        {
            // Arrange
            double expectedResult = firstNumber * secondNumber;
            double actualResult;

            // Act
            actualResult = Calculator.Multiply(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Theory]
        [InlineData(3, 5)]
        [InlineData(8.4, -7.55)]
        [InlineData(-2, 88.92)]
        public void Divide_TwoNumberCalcWorks(double firstNumber, double secondNumber)
        {
            // Arrange
            double expectedResult = firstNumber / secondNumber;
            double actualResult;

            // Act
            actualResult = Calculator.Divide(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void Add_OneSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35 };
            double expected = double.NaN;
            double result;

            // Act
            result = Calculator.Add(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Add_ThreeSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2 };
            double expected = testNumbers[0] + testNumbers[1] + testNumbers[2];
            double result;

            // Act
            result = Calculator.Add(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Add_NineSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2, -2.3, 5, 99.2, 74.3, 500.14, -111.92 };
            double expected = testNumbers[0] + testNumbers[1] + testNumbers[2] +
                testNumbers[3] + testNumbers[4] + testNumbers[5] +
                testNumbers[6] + testNumbers[7] + testNumbers[8];
            double result;

            // Act
            result = Calculator.Add(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Subtract_OneSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35 };
            double expected = double.NaN;
            double result;

            // Act
            result = Calculator.Subtract(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Subtract_ThreeSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2 };
            double expected = testNumbers[0] - testNumbers[1] - testNumbers[2];
            double result;

            // Act
            result = Calculator.Subtract(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Subtract_NineSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2, -2.3, 5, 99.2, 74.3, 500.14, -111.92 };
            double expected = testNumbers[0] - testNumbers[1] - testNumbers[2] -
                testNumbers[3] - testNumbers[4] - testNumbers[5] -
                testNumbers[6] - testNumbers[7] - testNumbers[8];
            double result;

            // Act
            result = Calculator.Subtract(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Multiply_OneSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35 };
            double expected = double.NaN;
            double result;

            // Act
            result = Calculator.Multiply(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Multiply_ThreeSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2 };
            double expected = testNumbers[0] * testNumbers[1] * testNumbers[2];
            double result;

            // Act
            result = Calculator.Multiply(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Multiply_NineSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2, -2.3, 5, 99.2, 74.3, 500.14, -111.92 };
            double expected = testNumbers[0] * testNumbers[1] * testNumbers[2] *
                testNumbers[3] * testNumbers[4] * testNumbers[5] *
                testNumbers[6] * testNumbers[7] * testNumbers[8];
            double result;

            // Act
            result = Calculator.Multiply(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Divide_OneSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35 };
            double expected = double.NaN;
            double result;

            // Act
            result = Calculator.Divide(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Divide_ThreeSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2 };
            double expected = testNumbers[0] / testNumbers[1] / testNumbers[2];
            double result;

            // Act
            result = Calculator.Divide(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Divide_NineSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2, -2.3, 5, 99.2, 74.3, 500.14, -111.92 };
            double expected = testNumbers[0] / testNumbers[1] / testNumbers[2] /
                testNumbers[3] / testNumbers[4] / testNumbers[5] /
                testNumbers[6] / testNumbers[7] / testNumbers[8];
            double result;

            // Act
            result = Calculator.Divide(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Divide_ByZeroThreeSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35, -8.95, 0 };
            double expected = double.NaN;
            double result;

            // Act
            result = Calculator.Divide(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
        [Fact]
        public void Divide_ByZeroNineSizedArrayCalcWorks()
        {
            // Arrange
            double[] testNumbers = { 3.35, -8.95, 82.2, -2.3, 5, 99.2, 74.3, 500.14, 0 };
            double expected = double.NaN;
            double result;

            // Act
            result = Calculator.Divide(testNumbers);

            // Assert
            Assert.Equal(expected, result, 2);
        }
    }
}
