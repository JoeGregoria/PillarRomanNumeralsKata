using RomanNumerals;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RomanNumeralsTests
{
    public class RomanNumeralToArabicNumberTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("Joe")]
        [InlineData("MMX8")]
        [InlineData("IIII")]
        [InlineData("MIIII")]
        public void GivenInvalidRomanNumeralShouldReturn0(string romanNumeral)
        {
            var romanNumeralToArabicNumber = new RomanNumeralToArabicNumber();
            Assert.Equal(0, romanNumeralToArabicNumber.Convert(null));
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("III", 3)]
        [InlineData("IX", 9)]
        [InlineData("MLXVI", 1066)]
        [InlineData("MCMLXXXIX", 1989)]
        public void GivenValidRomanNumeralShouldReturnArabicNumber(string romanNumeral, int arabicNumber)
        {
            var romanNumeralToArabicNumber = new RomanNumeralToArabicNumber();
            Assert.Equal(arabicNumber, romanNumeralToArabicNumber.Convert(romanNumeral));
        }
    }
}
