using RomanNumerals;
using System;

namespace PillarRomanNumeralsKata
{
    public class Convert
    {
        /// <summary>
        /// Command line interface to convert either arabic number or roman numerals to their corresponding opposite.
        /// </summary>
        /// <param name="args">either an integer representing an arabic number, or a string representing a roman numeral.</param>
        /// <returns>0 if not enough arguments; 1 otherwise. displays output on console.</returns>
        public static int Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.Error.WriteLine("usage: Convert <RomanNumeral-or-ArabicNumber>");
                return 0;
            }

            int integerValue;
            if (int.TryParse(args[0], out integerValue))
            {
                Console.WriteLine($"Converting arabic number {integerValue}");
                ArabicNumberToRomanNumeralConverter arabicNumberToRomanNumeral = new ArabicNumberToRomanNumeralConverter();
                Console.WriteLine(arabicNumberToRomanNumeral.Convert(integerValue));
                return 1;
            } 
            else
            {
                string romanNumeral = args[0];
                Console.WriteLine($"Converting roman numeral {romanNumeral}");
                RomanNumeralToArabicNumberConverter romanNumeralToArabicNumber = new RomanNumeralToArabicNumberConverter();
                Console.WriteLine(romanNumeralToArabicNumber.Convert(romanNumeral));
                return 1;
            }
        }
    }
}
