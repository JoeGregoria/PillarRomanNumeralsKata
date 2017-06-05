using Xunit;

namespace RomanNumeralsTests
{
    public class ConvertMainTests
    {
        [Fact]
        public void GivenNullArgumentsResultsInZero()
        {
            Assert.Equal(0, PillarRomanNumeralsKata.Convert.Main(null));
        }

        [Fact]
        public void GivenEmptyArgumentsResultsInZero()
        {
            Assert.Equal(0, PillarRomanNumeralsKata.Convert.Main(new string[0]));
        }

        [Fact]
        public void GivenRomanNumeralStringArgumentResultsInOne()
        {
            Assert.Equal(1, PillarRomanNumeralsKata.Convert.Main(new string[] { "X" }));
        }

        [Fact]
        public void GivenArabicNumberArgumentResultsInOne()
        {
            Assert.Equal(1, PillarRomanNumeralsKata.Convert.Main(new string[] { "10" }));
        }

        [Fact]
        public void GivenInvalidRomanNumeralStringArgumentResultsInOne()
        {
            Assert.Equal(1, PillarRomanNumeralsKata.Convert.Main(new string[] { "This is not a valid roman numeral" }));
        }
    }
}
