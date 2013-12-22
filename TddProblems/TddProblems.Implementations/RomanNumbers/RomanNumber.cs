using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddProblems.Implementations.RomanNumbers
{
    public static class RomanNumber
    {

        public static int ToInt(string romanNumber)
        {
            var number = 0;

            if (string.IsNullOrEmpty(romanNumber))
                throw new ArgumentException("The parameter null isn't a valid Romain Number");

            if (romanNumber.Length == 1)
                return ConvertSimpleNumber(romanNumber.FirstOrDefault());

            for (int index = 0; index < romanNumber.Count(); index++)
            {
                var currentValue = ConvertSimpleNumber(romanNumber[index]);
                var previousValue = 0;

                if (index > 0)
                    previousValue = ConvertSimpleNumber(romanNumber[index - 1]);

                if (previousValue != 0 && previousValue < currentValue)
                    number = (currentValue - previousValue);
                else
                    number += currentValue;
            }

            return number;
        }

        private static int ConvertSimpleNumber(char simpleRomanNumber)
        {
            int? convertedValue = null;

            if (!char.IsWhiteSpace(simpleRomanNumber))
            {
                convertedValue = RomainNumberDefinition.SimpleRomainNumber
                    .Where(number => number.Key == char.ToUpper(simpleRomanNumber))
                    .Select(number => number.Value).First();
            }

            if (convertedValue.HasValue)
                return convertedValue.Value;

            throw new ArgumentException(String.Format("The parameter {0} isn't a valid Romain Number", simpleRomanNumber));
        }
    }

    internal static class RomainNumberDefinition
    {
        public static Dictionary<char, int> SimpleRomainNumber = new Dictionary<char, int>(){
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };
    }

}
