using RomanNumerals;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RomanNumeralsTests
{
    public class RomanNumeralToArabicNumberTests
    {
        [Fact]
        public void GivenNullShouldReturn0()
        {
            var romanNumeralToArabicNumber = new RomanNumeralToArabicNumber();
            Assert.Equal(0, romanNumeralToArabicNumber.Convert(null));
        }

        [Fact]
        public void GivenEmptyShouldReturn0()
        {
            var romanNumeralToArabicNumber = new RomanNumeralToArabicNumber();
            Assert.Equal(0, romanNumeralToArabicNumber.Convert(""));
        }

        [Fact]
        public void GivenNotRomanAtAllShouldReturn0()
        {
            var romanNumeralToArabicNumber = new RomanNumeralToArabicNumber();
            Assert.Equal(0, romanNumeralToArabicNumber.Convert("JOE"));
        }

        [Fact]
        public void GivenPartialRomanShouldReturn0()
        {
            var romanNumeralToArabicNumber = new RomanNumeralToArabicNumber();
            Assert.Equal(0, romanNumeralToArabicNumber.Convert("MMX8"));
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("III", 3)]
        [InlineData("IX", 9)]
        [InlineData("MLXVI", 1066)]
        [InlineData("MCMLXXXIX", 1989)]
        public void GivenRomanNumeralShouldReturnArabic(string romanNumeral, int arabicNumber)
        {
            var romanNumeralToArabicNumber = new RomanNumeralToArabicNumber();
            Assert.Equal(arabicNumber, romanNumeralToArabicNumber.Convert(romanNumeral));
        }
    }
}
