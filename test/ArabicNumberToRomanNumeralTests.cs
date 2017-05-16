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

        [Fact]
        public void Given5ShouldReturnV()
        {
            ArabicNumberToRomanNumeral arabicNumberToRomanNumeral = new ArabicNumberToRomanNumeral();
            Assert.Equal("V", arabicNumberToRomanNumeral.Convert(5));
        }

        [Fact]
        public void Given10ShouldReturnX()
        {
            ArabicNumberToRomanNumeral arabicNumberToRomanNumeral = new ArabicNumberToRomanNumeral();
            Assert.Equal("X", arabicNumberToRomanNumeral.Convert(10));
        }

        [Fact]
        public void Given9ShouldReturnIX()
        {
            ArabicNumberToRomanNumeral arabicNumberToRomanNumeral = new ArabicNumberToRomanNumeral();
            Assert.Equal("IX", arabicNumberToRomanNumeral.Convert(9));
        }
    }
}
