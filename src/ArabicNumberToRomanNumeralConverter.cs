using System.Text;

namespace RomanNumerals
{
    /// <summary>
    ///  Convert an arabic number (aka, an integer) to a roman numeral string value.
    /// </summary>
    public class ArabicNumberToRomanNumeralConverter
    {
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

            foreach (var specialValueEntry in RomanNumeralArabicNumberMaps.ArabicToRomanDecendingSpecialValues)
            {
                // we depend on the keys to be decending for this algorithm to work
                while (valueRemaining >= specialValueEntry.Key)
                {
                    returnStringBuilder.Append(specialValueEntry.Value);
                    valueRemaining = valueRemaining - specialValueEntry.Key;
                }
            }

            return returnStringBuilder.ToString();
        }
    }
}
