using System;

namespace Tic_tac_toe_AI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Board b = FENExtractor.ExtractFEN("2x/oox/oo1 o");
            Console.WriteLine("Hello World!");
        }
    }
}