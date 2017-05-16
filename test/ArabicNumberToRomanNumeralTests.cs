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
    }
}
