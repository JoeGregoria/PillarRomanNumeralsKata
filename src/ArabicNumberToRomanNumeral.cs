using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class ArabicNumberToRomanNumeral
    {
        // The Romans wrote their numbers using letters; specifically the letters 'I' meaning '1', 'V' meaning '5', 'X' meaning '10', 
        // 'L' meaning '50', 'C' meaning '100', 'D' meaning '500', and 'M' meaning '1000'. There were certain rules that the numerals followed which should be observed.
        //
        // The symbols 'I', 'X', 'C', and 'M' can be repeated at most 3 times in a row. The symbols 'V', 'L', and 'D' can never be repeated. 
        // The '1' symbols ('I', 'X', and 'C') can only be subtracted from the 2 next highest values('IV' and 'IX', 'XL' and 'XC', 'CD' and 'CM'). 
        // Only one subtraction can be made per numeral('XC' is allowed, 'XXC' is not). The '5' symbols('V', 'L', and 'D') can never be subtracted.
        private SortedDictionary<int, string> ArabicToRomanMap = new SortedDictionary<int, string>(new DecendingIntegerComparer())
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

        public string Convert(int arabicValue)
        {
            int valueRemaining = arabicValue;
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var entry in ArabicToRomanMap)
            {
                while (valueRemaining >= entry.Key)
                {
                    stringBuilder.Append(entry.Value);
                    valueRemaining = valueRemaining - entry.Key;
                    if (valueRemaining == 0) break;
                }
            }

            return stringBuilder.ToString();
        }
    }
}
