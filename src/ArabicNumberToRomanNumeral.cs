using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class ArabicNumberToRomanNumeral
    {
        public string Convert(int value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < value; i++)
            {
                stringBuilder.Append("I");
            }
            return stringBuilder.ToString();
        }
    }
}
