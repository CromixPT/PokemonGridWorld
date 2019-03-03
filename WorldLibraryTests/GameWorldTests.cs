using WorldLibrary;
using Xunit;

namespace WorldLibraryTests
{
    public class GameWorldTests
    {

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
