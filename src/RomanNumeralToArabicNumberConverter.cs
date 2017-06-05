using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralToArabicNumberConverter
    {

        /// <summary>
        /// Convert a roman numeral string to its arabic value.
        /// </summary>
        /// <param name="value">the roman numeral value</param>
        /// <returns>The arabic value. 0 if the roman numeral is illegal.</returns>
        public int Convert(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return 0;

            if (ContainsAnIllegalRomanNumeralPattern(value)) return 0;
            
            int returnValue = 0;
            int romanIndex = 0;
            while (romanIndex < value.Length)
            {

                if (TryGetArabicValueBasedOnNextTwoRomanCharacters(value, romanIndex, out int twoCharArabicValue))
                {
                    returnValue += twoCharArabicValue;
                    romanIndex += 2;
                }
                else if (TryGetArabicValueBasedOnNextSingleRomanCharacter(value, romanIndex, out int oneCharArabicValue))
                {
                    returnValue += oneCharArabicValue;
                    romanIndex += 1;
                }
                else
                {
                    // this must be an invalid roman numeral character; we can stop and return 0.
                    return 0;
                }
            }

            return returnValue;
        }

        /// <summary>
        /// Check to see if there is an illegal roman numeral pattern in the string
        /// </summary>
        /// <param name="value">the roman numeral pattern</param>
        /// <returns>true if there is an illegal roman numeral pattern in the string; false otherwise</returns>
        private bool ContainsAnIllegalRomanNumeralPattern(string value)
        {
            foreach (string illegalString in RomanNumeralArabicNumberMaps.IllegalRomanNumeralPatterns)
            {
                if (value.Contains(illegalString)) return true;
            }
            return false;
        }

        /// <summary>
        /// Check to see if the next 2 characters have a match in the Roman Numeral table. This covers the special cases of 4, 5, 40, 400, and 900. 
        /// </summary>
        /// <param name="romanNumeralString">the full roman numeral string</param>
        /// <param name="romanNumeralStringIndex">the index at which we are starting</param>
        /// <param name="arabicValue">if there is a corresponding arabic value, it is returned here. If there is not,
        /// e.g., a two-character string is not in the special values table, then returns false and this value is 0</param>
        /// <returns>true if the value is found (and the valud is in 'arabicValue'), false otherwise</returns>
        private bool TryGetArabicValueBasedOnNextTwoRomanCharacters(string value, int romanIndex, out int twoCharArabicValue)
        {
            return TryGetArabicValue(value, romanIndex, 2, out twoCharArabicValue);
        }

        /// <summary>
        /// Check to see if the next character has a match in the Roman Numeral table.
        /// </summary>
        /// <param name="romanNumeralString">the full roman numeral string</param>
        /// <param name="romanNumeralStringIndex">the index at which we are starting</param>
        /// <param name="arabicValue">if there is a corresponding arabic value, it is returned here. If there is not,
        /// then returns false and this value is 0</param>
        /// <returns>true if the value is found (and the valud is in 'arabicValue'), false otherwise</returns>
        private bool TryGetArabicValueBasedOnNextSingleRomanCharacter(string value, int romanIndex, out int oneCharArabicValue)
        {
            return TryGetArabicValue(value, romanIndex, 1, out oneCharArabicValue);
        }

        /// <summary>
        /// Attempt to get the arabic/integer equivelant of a substring of roman numerals.
        /// </summary>
        /// <param name="romanNumeralString">the full roman numeral string</param>
        /// <param name="romanNumeralStringIndex">the index at which we are starting</param>
        /// <param name="numberOfCharactersToCheck">the number of characters to check (should be 1 or 2)</param>
        /// <param name="arabicValue">if there is a corresponding arabic value, it is returned here. If there is not,
        /// e.g., a two-character string is not in the special values table, then returns false and this value is 0</param>
        /// <returns>true if the value is found (and the valud is in 'arabicValue'), false otherwise</returns>
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
