 using System;

namespace StringCalculatorKata
{
    public class  StringCalculator
    {
        public int Add(string inputString)
        {
            string[] numbers = inputString.Split(",");

            var sum = int.Parse(numbers[0]) + int.Parse(numbers[1]);

            return sum;
        }
    }
}