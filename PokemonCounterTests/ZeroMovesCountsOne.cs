using System;
using Xunit;
using PokemonCounterApp;

namespace PokemonCounterTests
{
    public class ZeroMovesCountsOne
    {
        [Fact]
        public void NullLineReturnsOne()
        {
        //Given
        string line = "";
        PokemonCounter pokeBallTest = new PokemonCounter();
        //When
        pokeBallTest.ProcessLine(line);
        //Then
        Assert.Equal(1, pokeBallTest.Count);
        }
        [Fact]
        public void NullCharReturnsOne()
        {
            //Given
        char testNull = '\0'; 
        PokemonCounter pokeBallTest = new PokemonCounter();
        //When
        pokeBallTest.ProcessChar(testNull);
        //Then
        Assert.Equal(1, pokeBallTest.Count);
        }
    }
}
