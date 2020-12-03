using System.Collections.Generic;
namespace PokemonCounterApp
{
    public class PokemonCounter
{
    public int Count { get; private set;}
    private HashSet<string> pokeBall;

    private AshCoordinates currentPos;
    public PokemonCounter()
    {
        Count = 1;
        currentPos = new AshCoordinates(0,0);
        pokeBall = new HashSet<string>();
        pokeBall.Add(currentPos.ToString());
    }
    public int ProcessChar(char direction)
    {
        int pokemon = 0;
        if ("EONS".Contains(direction))
        {
            currentPos.Move(direction);
            if(pokeBall.Add(currentPos.ToString()))
            {
                pokemon = 1;
                Count++;
            }
        }
        return pokemon;
    }
    public int ProcessLine(string movements)
    {
        int pokemons = 0;
        foreach (char direction in movements)
        {
            pokemons += ProcessChar(direction); 
        }
        return pokemons;
    }
    
}
}
