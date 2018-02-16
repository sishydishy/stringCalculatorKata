using Xunit;

namespace StringCalculatorKata
{
    public class StringCalculatorTest
    {
        [Fact]
        public void GivenEmptyStringShouldReturnZero()
        {
            var expectedSumResult = 0;
            var stringCalculator = new StringCalculator();
            var actualSumResult = stringCalculator.Add("");

            Assert.Equal(expectedSumResult, actualSumResult);
        }

        [Fact]
        public void GivenStringContainingNumberShouldReturnInteger()
        {
            var expectedSumResult = 1;
            var inputString = "1";
            var stringCalculator = new StringCalculator();

            var actualSumResult = stringCalculator.Add(inputString);
            
            Assert.Equal(expectedSumResult, actualSumResult);
        }
    }
}
