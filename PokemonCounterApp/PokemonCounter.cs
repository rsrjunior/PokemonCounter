using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PokemonCounterApp
{
    public class PokemonCounter
    {
        public int Count { get; private set; }
        private HashSet<string> pokeBall;
        private List<string> oneDirectionRegex;
        private AshCoordinates currentPos;
        public PokemonCounter()
        {
            Count = 1;
            currentPos = new AshCoordinates(0, 0);
            pokeBall = new HashSet<string>();
            pokeBall.Add(currentPos.ToString());
            oneDirectionRegex = new List<string>(5);
            oneDirectionRegex.Add("^E+$|^O+$|^N+$|^S+$");
            oneDirectionRegex.Add("^(E*S+O*S+)+$");
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

            Match m;
            foreach (string item in oneDirectionRegex)
            {
                m = Regex.Match(movements, item);
                if (m.Success)
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
