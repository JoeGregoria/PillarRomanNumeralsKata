using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class ArabicNumberToRomanNumeral
    {
        private SortedDictionary<int, string> ArabicToRomanMap = new SortedDictionary<int, string>(new DecendingIntegerComparer())
        {
            { 10, "X" },
            {  9, "IX" },
            {  5, "V" },
            {  4, "IV" },
            {  1, "I" }
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
