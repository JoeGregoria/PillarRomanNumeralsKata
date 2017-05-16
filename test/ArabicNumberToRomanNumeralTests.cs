using RomanNumerals;
using System;
using Xunit;

namespace RomanNumeralsTests
{
    public class ArabicNumberToRomanNumeralTests
    {
        [Fact]
        public void Given1ShouldReturnI()
        {
            ArabicNumberToRomanNumeral arabicNumberToRomanNumeral = new ArabicNumberToRomanNumeral();
            Assert.Equal("I", arabicNumberToRomanNumeral.Convert(1));
        }

        [Fact]
        public void Given3ShouldReturnIII()
        {
            ArabicNumberToRomanNumeral arabicNumberToRomanNumeral = new ArabicNumberToRomanNumeral();
            Assert.Equal("III", arabicNumberToRomanNumeral.Convert(3));
        }
    }
}
