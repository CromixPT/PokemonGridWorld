using WorldLibrary;
using Xunit;

namespace WorldLibraryTests
{

    public class StringProcessorTests
    {
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

    }
}
