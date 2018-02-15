using System;
using Xunit;

namespace StringCalculatorKata
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            var calculator = new Calculator();
            var result = calculator.plus(2, 1);
            
            
            Assert.Equal(2, result);
        }
    }
}
