using System;
using Xunit;
using PokemonCounterApp;

namespace PokemonCounterTests
{
    public class ValidMovementsTest
    {
    [Theory]
    [InlineData('E', 2)]
    [InlineData('O', 2)]
    [InlineData('N', 2)]
    [InlineData('S', 2)]
    public void FirstValidCharPickTwoPokes(char input, int output)
    {
        PokemonCounter pokeBallTest = new PokemonCounter();

        pokeBallTest.ProcessChar(input);

        Assert.Equal(output, pokeBallTest.Count);
    }   
    }
}