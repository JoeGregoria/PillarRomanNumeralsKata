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
        public void GivenRomanNumeralStringArgumentResultsIn1()
        {
            Assert.Equal(1, PillarRomanNumeralsKata.Convert.Main(new string[] { "X" }));
        }
    }
}
