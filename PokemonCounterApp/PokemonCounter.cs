using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PokemonCounterApp
{
    public class PokemonCounter
    {
        public int Count { get; private set; }
        private HashSet<string> pokeBall;
        private List<Regex> oneDirectionRegex;
        private AshCoordinates currentPos;
        public PokemonCounter()
        {
            Count = 1;
            currentPos = new AshCoordinates(0, 0);
            pokeBall = new HashSet<string>();
            pokeBall.Add(currentPos.ToString());
            oneDirectionRegex = new List<Regex>(9);
            //all directions straight
            oneDirectionRegex.Add(new Regex(@"^E+$|^O+$|^N+$|^S+$",RegexOptions.Compiled));
            //all directions zigzag
            oneDirectionRegex.Add(new Regex(@"^(E+S+O+S+)+$", RegexOptions.Compiled));
            oneDirectionRegex.Add(new Regex(@"^(O+S+E+S+)+$", RegexOptions.Compiled));
            oneDirectionRegex.Add(new Regex(@"^(N+E+S+E+)+$", RegexOptions.Compiled));
            oneDirectionRegex.Add(new Regex(@"^(S+E+N+E+)+$", RegexOptions.Compiled));
            oneDirectionRegex.Add(new Regex(@"^(O+N+E+N+)+$", RegexOptions.Compiled));
            oneDirectionRegex.Add(new Regex(@"^(E+N+O+N+)+$", RegexOptions.Compiled));
            oneDirectionRegex.Add(new Regex(@"^(S+O+N+O+)+$", RegexOptions.Compiled));
            oneDirectionRegex.Add(new Regex(@"^(N+O+S+O+)+$", RegexOptions.Compiled));
        }
        public int ProcessChar(char direction)
        {
            int pokemon = 0;
            if ("EONS".Contains(direction))
            {
                currentPos.Move(direction);
                if (pokeBall.Add(currentPos.ToString()))
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

            foreach (Regex rx in oneDirectionRegex)
            {
                if (rx.IsMatch(movements))
                {
                    Count += movements.Length;
                    pokemons += movements.Length;
                    movements = "";
                }
            }


            foreach (char direction in movements)
            {
                pokemons += ProcessChar(direction);
            }
            return pokemons;
        }

    }
}
