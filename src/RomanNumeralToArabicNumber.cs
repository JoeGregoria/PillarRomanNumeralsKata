using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralToArabicNumber
    {
        public int Convert(string value)
        {
            int returnValue = 0;

            foreach (char romanDigit in value.ToCharArray())
            {
                returnValue += 1;
            }

            return returnValue;
        }
    }
}
