using Xunit;

namespace StringCalculatorKata
{
    public class StringCalculatorTest
    {
        private StringCalculator _stringCalculator = new StringCalculator();

        [Fact]
        public void GivenEmptyStringShouldReturnZero()
        {
            var expectedSumResult = 0;
            var actualSumResult = _stringCalculator.Add("");

            Assert.Equal(expectedSumResult, actualSumResult);
        }

        [Fact]
        public void GivenStringContainingOneShouldReturnIntegerOne()
        {
            var expectedSumResult = 1;
            const string inputNumber = "1";

            var actualSumResult = _stringCalculator.Add(inputNumber);
            
            Assert.Equal(expectedSumResult, actualSumResult);
        }

        [Fact]
        public void GivenAStringOfTwoNumbersShouldReturnItsSum()
        {
            var expectedSumResult = 3;
            const string inputNumbers = "1,2";

            var actualSumResult = _stringCalculator.Add(inputNumbers);
            
            Assert.Equal(expectedSumResult,actualSumResult);
            
        }
    }
}
