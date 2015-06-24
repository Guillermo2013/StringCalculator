using System;

namespace StringCalculator
{
    public class InvalidInputFormat : Exception
    {
        public InvalidInputFormat(string input) : base("---"+input+"---")
        {
            
        }
    }
}