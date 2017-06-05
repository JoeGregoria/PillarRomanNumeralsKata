using RomanNumerals;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RomanNumeralsTests
{
    public class RomanNumeralToArabicNumberConverterTests
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
            var converter = new RomanNumeralToArabicNumberConverter();
            Assert.Equal(0, converter.Convert(null));
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("III", 3)]
        [InlineData("IX", 9)]
        [InlineData("MLXVI", 1066)]
        [InlineData("MCMLXXXIX", 1989)]
        public void GivenValidRomanNumeralShouldReturnArabicNumber(string romanNumeral, int arabicNumber)
        {
            var converter = new RomanNumeralToArabicNumberConverter();
            Assert.Equal(arabicNumber, converter.Convert(romanNumeral));
        }
    }
}
