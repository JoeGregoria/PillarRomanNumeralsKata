using RomanNumerals;
using System;
using Xunit;

namespace RomanNumeralsTests
{
    public class ArabicNumberToRomanNumeralTests
    {
        [Fact]
        public void GivenZeroShouldReturnNothing()
        {
            //https://en.wikipedia.org/wiki/Roman_numerals#Zero
            ArabicNumberToRomanNumeral arabicNumberToRomanNumeral = new ArabicNumberToRomanNumeral();
            Assert.Equal("", arabicNumberToRomanNumeral.Convert(0));
        }

        [Fact]
        public void GivenNegativeNumberShouldReturnNothing()
        {
            // http://turner.faculty.swau.edu/mathematics/materialslibrary/roman/
            ArabicNumberToRomanNumeral arabicNumberToRomanNumeral = new ArabicNumberToRomanNumeral();
            Assert.Equal("", arabicNumberToRomanNumeral.Convert(-11));
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(20, "XX")]
        [InlineData(1066, "MLXVI")]
        [InlineData(1989, "MCMLXXXIX")]
        [InlineData(2017, "MMXVII")]
        public void GivenANumberShouldGetTheExpectedRomanNumeral(int arabic, string roman)
        {
            ArabicNumberToRomanNumeral arabicNumberToRomanNumeral = new ArabicNumberToRomanNumeral();
            Assert.Equal(roman, arabicNumberToRomanNumeral.Convert(arabic));
        }
    }
}
