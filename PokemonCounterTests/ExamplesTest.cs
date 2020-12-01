using System;
using Xunit;
using PokemonCounterApp;

namespace PokemonCounterTests
{
    public class ExamplesTest
    {
        [Theory]
        [InlineData("E", 2)]
        [InlineData("NESO", 4)]
        [InlineData("NSNSNSNSNS", 2)]
        public void AssertDescriptionInputs(string input, int output)
        {
            PokemonCounter pokeBallTest = new PokemonCounter();

            pokeBallTest.ProcessLine(input);

            Assert.Equal(output, pokeBallTest.Count);
        }
    }
}
