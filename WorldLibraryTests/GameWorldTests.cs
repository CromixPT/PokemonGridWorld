using WorldLibrary;
using Xunit;

namespace WorldLibraryTests
{
    public class GameWorldTests
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




        [Theory]
        [InlineData("E", 2)]
        [InlineData("NESO", 4)]
        [InlineData("NSNSNSNSN", 2)]
        [InlineData("NSNSESO", 5)]
        [InlineData("NEOS", 3)]
        [InlineData("nnnnsseoossnee", 10)]
        [InlineData("seenoooneeno", 12)]
        [InlineData("eenpnoosenneenooss", 15)]
        [InlineData("eennooosseeennooosseeennooosseeennooosseeennooosseeennooosseeennooosseeennooosse", 10)]
        [InlineData("eennooosseeennooosseeennooosseeennooosseeennooosseeennooosseeennooosseeennooossen", 11)]
        public void Play_PokemonsCount_ShouldPass(string input, int expected)
        {

            var actual = GameWorld.Play(input);

            Assert.Equal(expected, actual);
        }
    }
}
