using RomanNumerals;
using System;

namespace PillarRomanNumeralsKata
{
    class Convert
    {
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
                ArabicNumberToRomanNumeral arabicNumberToRomanNumeral = new ArabicNumberToRomanNumeral();
                Console.WriteLine(arabicNumberToRomanNumeral.Convert(integerValue));
                return 1;
            } 
            else
            {
                string romanNumeral = args[0];
                Console.WriteLine($"Converting roman numeral {romanNumeral}");
                RomanNumeralToArabicNumber romanNumeralToArabicNumber = new RomanNumeralToArabicNumber();
                Console.WriteLine(romanNumeralToArabicNumber.Convert(romanNumeral));
                return 1;
            }
        }
    }
}
