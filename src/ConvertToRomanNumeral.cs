using RomanNumerals;
using System;

namespace PillarRomanNumeralsKata
{
    class ConvertToRomanNumeral
    {
        public static int Main(string[] args)
        {
            if (args == null)
            {
                Console.Error.WriteLine("usage: ConvertToRomanNumeral <number>");
                return 0;
            }

            int value;
            if (!int.TryParse(args[0], out value))
            {
                Console.Error.Write("cannot parse input; must be an integer");
                return 0;
            }

            ArabicNumberToRomanNumeral arabicNumberToRomanNumeral = new ArabicNumberToRomanNumeral();
            Console.WriteLine(arabicNumberToRomanNumeral.Convert(value));
            return 1;
        }
    }
}
