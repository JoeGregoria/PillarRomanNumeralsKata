using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class ArabicNumberToRomanNumeral
    {
        private SortedDictionary<int, string> ArabicToRomanDictionary = new SortedDictionary<int, string>(new IntComparerHighestFirst())
        {
            { 10, "X" },
            {  5, "V" },
            {  1, "I" }
        };

        public string Convert(int value)
        {
            int valueRemaining = value;
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var entry in ArabicToRomanDictionary)
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

    public class IntComparerHighestFirst : IComparer<int>
    {
        public int Compare(int left, int right)
        {
            if (left == right) return 0;
            if (left < right) return 1;
            if (left > right) return -1;
            throw new ArgumentException("what the heck?");
        }
    }
}
