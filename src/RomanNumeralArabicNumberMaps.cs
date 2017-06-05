using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    /// <summary>
    /// Maps of interesting and useful facts about roman numerals that help in the translation to and from arabic numbers.
    /// </summary>
    public static class RomanNumeralArabicNumberMaps
    {
        /// <summary>
        /// A mapping of special arabic numbers to their roman numeral counterpart. This map is used to drive the creation of the roman from the arabic.
        /// The Keys are arabic integers were something interesting happens; the Values are their roman rumeral equivalant.
        /// We include values like "CM", "CD", "XC", "XL", "IX", and "IV" to keep the algorithm cleaner.
        /// The algorithm depends on the keys to be in decending order.
        /// </summary>
        public static readonly IDictionary<int, string> ArabicToRomanDecendingSpecialValues;

        /// <summary>
        /// A mapping of roman numeral special strings to their arabic number counterpart. 
        /// </summary>
        public static readonly IDictionary<string, int> RomanToArabicSpecialValues;

        /// <summary>
        /// The base dictionary, upon which all other maps are created.
        /// </summary>
        private static SortedDictionary<int, string> m_specialValues = new SortedDictionary<int, string>()
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
        /// Static constructor; creates the *SpecialValues dictionaries.
        /// </summary>
        static RomanNumeralArabicNumberMaps()
        {
            // To not use a custom IComparer, we need to create a new IOrderedEnumerable in descending order, and then turn it back in to a dictionary.
            ArabicToRomanDecendingSpecialValues = m_specialValues.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

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
