using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralToArabicNumber
    {

        /// <summary>
        /// Convert a roman numeral string to its arabic value.
        /// </summary>
        /// <param name="value">the roman numeral value</param>
        /// <returns>The arabic value. 0 if the roman numeral is illegal.</returns>
        public int Convert(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return 0;

            // check the illegal cases (e.g., two or more V's in a row, more than three I's in a row, etc)
            foreach(string illegalString in RomanNumeralArabicNumberMaps.IllegalRomanNumeralPatterns)
            {
                if (value.Contains(illegalString)) return 0;
            }
            
            int returnValue = 0;
            int romanIndex = 0;
            while (romanIndex < value.Length)
            {
                // first check to see if the next 2 characters have a match in the Roman Numeral table.
                // This covers the special cases of 4, 5, 40, 400, and 900. 
                if (TryGetArabicValue(value, romanIndex, 2, out int twoCharArabicValue))
                {
                    returnValue += twoCharArabicValue;
                    romanIndex += 2;
                }
                else if (TryGetArabicValue(value, romanIndex, 1, out int oneCharArabicValue))
                {
                    // we didn't find a pair match, so check just one character
                    returnValue += oneCharArabicValue;
                    romanIndex += 1;
                }
                else
                {
                    // didn't find this numeral in our dictionary, so it must be an invalid roman numeral character.
                    return 0;
                }
            }

            return returnValue;
        }

        private bool TryGetArabicValue(string romanNumeralString, int romanNumeralStringIndex, int numberOfCharactersToCheck, out int arabicValue)
        {
            if ((romanNumeralStringIndex + numberOfCharactersToCheck) <= romanNumeralString.Length)
            {
                string numeralsToCheck = romanNumeralString.Substring(romanNumeralStringIndex, numberOfCharactersToCheck);
                if (RomanNumeralArabicNumberMaps.RomanToArabicSpecialValues.TryGetValue(numeralsToCheck, out int value))
                {
                    arabicValue = value;
                    return true;
                }
            }
            arabicValue = 0;
            return false;
        }
    }
}
