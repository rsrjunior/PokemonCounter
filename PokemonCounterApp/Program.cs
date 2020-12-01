using System;
using System.IO;

namespace PokemonCounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonCounter pokeBall;
            string line;
            long pokeCount = 0;

            if (args.Length > 0)
            {
                Console.WriteLine("Arquivo {0}", args[0]);
                try
                {
                    using (StreamReader sr = new StreamReader(args[0]))
                    {
                        if ((line = sr.ReadLine()) != null)
                        {
                            try
                            {
                                pokeBall = new PokemonCounter();
                                pokeBall.ProcessLine(line);
                                pokeCount = pokeBall.Count;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Something wrong in our world.... " + e.Message);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                try
                {
                    pokeBall = new PokemonCounter();
                    Console.Write("GoAsh>>>");
                    line = Console.ReadLine();
                    pokeBall.ProcessLine(line);
                    pokeCount = pokeBall.Count;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something wrong in our world.... " + e.Message);
                }

            }
            Console.WriteLine(pokeCount);
        }
    }
}
