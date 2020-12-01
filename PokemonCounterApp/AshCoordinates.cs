using System;

namespace PokemonCounterApp
{
    public  class AshCoordinates
{
    public  AshCoordinates()
    {
        X = 0;
        Y = 0;
    }
    public AshCoordinates(long x, long y)
    {
        X = x;
        Y = y;
    }
    public long X { get; set; }
    public long Y { get; set; }

    public override string ToString()
    {
        string r = "";

        r+= X<0? "-": "+"; 
        r+= X;
        r+= Y<0? "-": "+"; 
        r+= Y;
        
        return r;

    }

    internal void Move(char direction)
    {
        switch (direction)
        {
            case 'E':
                X--;
            break;
            case 'O':
                X++;
            break;
            case 'N':
                Y++;
            break;
            case 'S':
                Y--;
            break;
        }
    }
}    
}