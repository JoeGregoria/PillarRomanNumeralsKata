using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralToArabicNumber
    {


        public int Convert(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return 0;
            int returnValue = 0;

            int romanIndex = 0;

            while (romanIndex < value.Length)
            {
                // first check to see if the next 2 characters have a match in the Roman Numeral table.
                // This covers the special cases of 4, 5, 40, 400, and 900. 
                if ((romanIndex + 1) < value.Length)
                {
                    string numeralsToCheck = value.Substring(romanIndex, 2);
                    if (RomanNumeralArabicNumberMaps.RomanToArabicSpecialValues.TryGetValue(numeralsToCheck, out int twoCharRomanValue))
                    {
                        returnValue += twoCharRomanValue;
                        romanIndex += 2;
                        continue;
                    }
                }
                // we didn't find a pair match, so check just this 
                if (RomanNumeralArabicNumberMaps.RomanToArabicSpecialValues.TryGetValue(value.Substring(romanIndex, 1), out int oneCharRomanValue))
                {
                    returnValue += oneCharRomanValue;
                    romanIndex += 1;
                }
                else
                {
                    // didn't find this numerals in our dictionary, so it must be an invalid roman numeral.
                    return 0;
                }
            }

            return returnValue;
        }
    }
}
