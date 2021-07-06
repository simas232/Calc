using Xunit;
using Calc.Utilities;
using System;

namespace Calc.Tests
{
    public class InputTests
    {
        [Fact]
        public void StringInputSingleValueParsingWorks()
        {
            // Arrange
            string testInput = "3,35";

            double[] result;
            double[] expected = { 3.35 };

            // Act
            result = Input.ParseDoubleInput(testInput);

            // Assert
            Assert.Equal(result, expected);
        }
        [Fact]
        public void StringInputThreeValuesParsingWorks()
        {
            //Arrange
            string testInput = "3,35 -8,95 82,2";

            double[] result;
            double[] expected = { 3.35, -8.95, 82.2 };

            //Act
            result = Input.ParseDoubleInput(testInput);

            //Assert
            Assert.Equal(result, expected);
        }
        [Fact]
        public void StringInputNineValuesParsingWorks()
        {
            //Arrange
            string testInput = "3,35 -8,95 82,2 -2,3 5 99,2 74,3 500,14 -111,92";

            double[] result;
            double[] expected = { 3.35, - 8.95, 82.2, -2.3, 5, 99.2, 74.3, 500.14, -111.92 };

            //Act
            result = Input.ParseDoubleInput(testInput);

            //Assert
            Assert.Equal(result, expected);
        }
        [Fact]
        public void StringInputOnIncorrectInputFails()
        {
            //Arrange
            string testInput = "3.35";

            //Act
            FormatException resultMessage = Assert.Throws<FormatException>(
                () => Input.ParseDoubleInput(testInput));

            //Assert
            Assert.Equal("Input string was not in a correct format.", resultMessage.Message);
        }
    }
}

