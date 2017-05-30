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
        public void GivenIShouldReturn1()
        {
            var romanNumeralToArabicNumber = new RomanNumeralToArabicNumber();
            Assert.Equal(1, romanNumeralToArabicNumber.Convert("I"));
        }
    }
}
