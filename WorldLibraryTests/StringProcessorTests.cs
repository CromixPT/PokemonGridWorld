using WorldLibrary;
using Xunit;

namespace WorldLibraryTests
{

    public class StringProcessorTests
    {
        #region isCharacterValid_Testing
        [Theory]
        [InlineData('N')]
        [InlineData('S')]
        [InlineData('O')]
        [InlineData('E')]
        public void isCharacterValid_ValidChars_ShouldPass(char input)
        {
            bool actual = StringProcessor.isCharacterValid(input);

            Assert.True(actual);
        }



        [Theory]
        [InlineData('F')]
        [InlineData('R')]
        [InlineData('Q')]
        [InlineData('P')]
        [InlineData('1')]
        [InlineData('/')]
        public void isCharacterValid_InvalidChars_ShouldFail(char input)
        {
            bool actual = StringProcessor.isCharacterValid(input);

            Assert.False(actual);
        }
        #endregion



        #region ProcessString_Testing
        [Theory]
        [InlineData("NN", 2)]
        [InlineData("NPN", 2)]
        [InlineData("NESPO", 4)]
        [InlineData("NSNSNSEODFRROO", 10)]
        public void ProcessString_CharacterCount_ShouldPass(string input, int expectedValue)
        {
            var actual = StringProcessor.ProcessString(input).Count;

            Assert.Equal(expectedValue, actual);
        }
        #endregion
    }
}
