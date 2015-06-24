using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        private IStringCalculatorParser _parser;

        public Calculator(IStringCalculatorParser parser)
        {
            _parser = parser;
        }

        public Calculator()
        {
            _parser = new StringCalculatorParser();
        }

        public int Add(string input)
        {
            int [] numbersToAdd = _parser.Parse(input);
            return numbersToAdd.Sum();
        }
    }
}   