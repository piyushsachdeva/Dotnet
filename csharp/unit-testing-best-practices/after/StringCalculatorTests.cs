using System;
using UnitTestingBestPractices;
using Xunit;

namespace UnitTestingBestPracticesAfter
{
    public class StringCalculatorTests
    {
        // <SnippetAfterNamingAndMinimallyPassing>
        [Fact]
        public void Add_SingleNumber_ReturnsSameNumber()
        {
            //Arrange
            var stringCalculator = new StringCalculator();
            
            //Act
            var actual = stringCalculator.Add("0");
            
            //Assert
            Assert.Equal(0, actual);
        }
        // </SnippetAfterNamingAndMinimallyPassing>

        // <SnippetAfterArranging>
        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            //Arrange
            var stringCalculator = new StringCalculator();
            
            //Act         
            var actual = stringCalculator.Add("");

             //Assert
            Assert.Equal(0, actual);
        }
        // </SnippetAfterArranging>

        // <SnippetAfterHelperMethod>
        [Fact]
        public void Add_TwoNumbers_ReturnsSumOfNumbers()
        {
            //Arrange
            var stringCalculator = CreateDefaultStringCalculator();

            //Act         
            var actual = stringCalculator.Add("0,1");

            //Assert
            Assert.Equal(1, actual);
        }
        // </SnippetAfterHelperMethod>

        // <SnippetAfterTestLogic>
        [Theory]
        [InlineData("0,0,0", 0)]
        [InlineData("0,1,2", 3)]
        [InlineData("1,2,3", 6)]
        public void Add_MultipleNumbers_ReturnsSumOfNumbers(string input, int expected)
        {
            //Arrange
            var stringCalculator = new StringCalculator();

            //Act   
            var actual = stringCalculator.Add(input);

            //Assert
            Assert.Equal(expected, actual);
        }
        // </SnippetAfterTestLogic>

        // <SnippetAfterMagicString>
        [Fact]
        void Add_MaximumSumResult_ThrowsOverflowException()
        {
            //Arrange
            var stringCalculator = new StringCalculator();
            const string MAXIMUM_RESULT = "1001";

            //Act   
            Action actual = () => stringCalculator.Add(MAXIMUM_RESULT);

            //Assert
            Assert.Throws<OverflowException>(actual);
        }
        // </SnippetAfterMagicString>

        // <SnippetAfterMultipleAsserts>
        [Theory]
        [InlineData(null)]
        [InlineData("a")]
        public void Add_InputNullOrAlphabetic_ThrowsArgumentException(string input)
        {
            //Arrange
            var stringCalculator = new StringCalculator();
    
            //Act
            Action actual = () => stringCalculator.Add(input);

            //Assert
            Assert.Throws<ArgumentException>(actual);
        }
        // </SnippetAfterMultipleAsserts>

        // <SnippetAfterSetup>
        private StringCalculator CreateDefaultStringCalculator()
        {
            return new StringCalculator();
        }
        // </SnippetAfterSetup>
    }
}
