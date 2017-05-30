using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    /// <summary>
    ///  The Romans wrote their numbers using letters; specifically the letters 'I' meaning '1', 'V' meaning '5', 'X' meaning '10', 
    /// 'L' meaning '50', 'C' meaning '100', 'D' meaning '500', and 'M' meaning '1000'. 
    /// 
    /// There were certain rules that the numerals followed which should be observed:
    ///
    /// The symbols 'I', 'X', 'C', and 'M' can be repeated at most 3 times in a row. The symbols 'V', 'L', and 'D' can never be repeated. 
    /// The '1' symbols ('I', 'X', and 'C') can only be subtracted from the 2 next highest values('IV' and 'IX', 'XL' and 'XC', 'CD' and 'CM'). 
    /// Only one subtraction can be made per numeral('XC' is allowed, 'XXC' is not). The '5' symbols('V', 'L', and 'D') can never be subtracted.
    /// </summary>
    public class ArabicNumberToRomanNumeral
    {
       
        /// <summary>
        /// A mapping of special arabic numbers to their roman numeral counterpart. This map is used to drive the creation of the roman from the arabic.
        /// The Keys are arabic integers were something interesting happens; the Values are their roman rumeral equivalant.
        /// We include values like "CM", "CD", "XC", "XL", "IX", and "IV" to keep the algorithm cleaner.
        /// The algorithm depends on the keys to be in decending order.
        /// </summary>
        private SortedDictionary<int, string> ArabicToRomanDecendingSpecialValues = new SortedDictionary<int, string>(new DecendingIntegerComparer())
        {
            {1000, "M"  },
            { 900, "CM" },  // special case
            { 500, "D"  },
            { 400, "CD" },  // special case
            { 100, "C"  },
            {  90, "XC" },  // special case
            {  50, "L"  },
            {  40, "XL" },  // special case
            {  10, "X"  },
            {   9, "IX" },  // special case
            {   5, "V"  },
            {   4, "IV" },  // special case
            {   1, "I"  }
        };

        /// <summary>
        /// Convert an integer in to its roman numeral equivalant.
        /// </summary>
        /// <param name="value">the number to convert to a roman numeral</param>
        /// <returns>a string containing the roman numeral value. 
        /// Will be empty for values that cannot be expressed in roman numerals (e.g., zero, negative numbers)</returns>
        public string Convert(int value)
        {
            int valueRemaining = value;
            StringBuilder returnStringBuilder = new StringBuilder();

            foreach (var specialValueEntry in ArabicToRomanDecendingSpecialValues)
            {
                // we depend on the keys to be decending for this algorithm to work
                while (valueRemaining >= specialValueEntry.Key)
                {
                    returnStringBuilder.Append(specialValueEntry.Value);
                    valueRemaining = valueRemaining - specialValueEntry.Key;
                    if (valueRemaining == 0) break;
                }
            }

            return returnStringBuilder.ToString();
        }
    }
}
