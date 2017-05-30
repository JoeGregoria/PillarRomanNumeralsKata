using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public static class RomanNumeralArabicNumberMaps
    {
        /// <summary>
        /// A mapping of special arabic numbers to their roman numeral counterpart. This map is used to drive the creation of the roman from the arabic.
        /// The Keys are arabic integers were something interesting happens; the Values are their roman rumeral equivalant.
        /// We include values like "CM", "CD", "XC", "XL", "IX", and "IV" to keep the algorithm cleaner.
        /// The algorithm depends on the keys to be in decending order.
        /// </summary>
        public static readonly SortedDictionary<int, string> ArabicToRomanDecendingSpecialValues = new SortedDictionary<int, string>(new DecendingIntegerComparer())
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
        /// A mapping of roman numeral special strings to their arabic number counterpart. 
        /// </summary>
        public static readonly Dictionary<string, int> RomanToArabicSpecialValues;
        static RomanNumeralArabicNumberMaps()
        {
            // construct the inverse-dictionary of the arabic-to-roman table at run time, so we only have one master copy
            RomanToArabicSpecialValues = new Dictionary<string, int>();
            foreach(var entry in ArabicToRomanDecendingSpecialValues)
            {
                RomanToArabicSpecialValues.Add(entry.Value, entry.Key);
            }
        }

        public static IReadOnlyList<string> IllegalRomanNumeralPatterns = new List<string>()
        {
            //The symbols 'I', 'X', 'C', and 'M' can be repeated at most 3 times in a row. 
            "IIII",
            "XXXX",
            "MMMM",
            //The symbols 'V', 'L', and 'D' can never be repeated
            "VV",
            "LL",
            "DD"
        };
    }
}
