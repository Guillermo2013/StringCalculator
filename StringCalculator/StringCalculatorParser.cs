using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class StringCalculatorParser : IStringCalculatorParser
    {
        public int[] Parse(string input)
        {
            string prefix="";
            
            if (input == "")
                return new int[]{};

            if (HasPrefix(input))
            {
                prefix = ObtainPrefix(input);
                ValidatePrefix(prefix);
                input = ObtainInputWithoutPrefix();
            }

            var inputDelimiters = GetDelimiters(prefix);
            ValidateInput(input,inputDelimiters);
            return ObtainNumbersList(input, inputDelimiters);
        }

        private void ValidatePrefix(string prefix)
        {
            throw new NotImplementedException();
        }

        private void ValidateInput(string input, List<char> inputDelimiters)
        {
            throw new NotImplementedException();
        }

        private string ObtainInputWithoutPrefix()
        {
            throw new NotImplementedException();
        }

        private string ObtainPrefix(string input)
        {
            throw new NotImplementedException();
        }

        private bool HasPrefix(string input)
        {
            throw new NotImplementedException();
        }

        private static int[] ObtainNumbersList(string input, List<char> inputDelimiters)
        {
            var list = new List<int>();
            string[] numbers = input.Split(inputDelimiters.ToArray());
            for (int i = 0; i < numbers.Length; i++)
                list.Add(Convert.ToInt32(numbers[i]));
            return list.ToArray();
        }

        private List<char> GetDelimiters(string input)
        {
            
            var listDelimiter = new List<char>(new char[] { ',', '\n' });
            
            if (input.StartsWith("//"))
                listDelimiter.Add(input[2]);
            return listDelimiter;
        }
    }
}