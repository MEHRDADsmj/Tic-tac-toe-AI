using System;

namespace Tic_tac_toe_AI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            T3Board b = FENExtractor.ExtractFEN("2x/oox/oo1 o");
            Console.WriteLine("Hello World!");
        }
    }
}