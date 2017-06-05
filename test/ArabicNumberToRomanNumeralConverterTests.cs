using RomanNumerals;
using Xunit;

namespace RomanNumeralsTests
{
    public class ArabicNumberToRomanNumeralConverterTests
    {
        [Fact]
        public void GivenZeroShouldReturnNothing()
        {
            //https://en.wikipedia.org/wiki/Roman_numerals#Zero
            var converter = new ArabicNumberToRomanNumeralConverter();
            Assert.Equal("", converter.Convert(0));
        }

        [Fact]
        public void GivenNegativeNumberShouldReturnNothing()
        {
            // http://turner.faculty.swau.edu/mathematics/materialslibrary/roman/
            var converter = new ArabicNumberToRomanNumeralConverter();
            Assert.Equal("", converter.Convert(-11));
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
            var converter = new ArabicNumberToRomanNumeralConverter();
            Assert.Equal(roman, converter.Convert(arabic));
        }
    }
}
