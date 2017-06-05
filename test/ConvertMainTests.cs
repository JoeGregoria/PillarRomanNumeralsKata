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
    }
}
