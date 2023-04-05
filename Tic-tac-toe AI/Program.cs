using System;

namespace Tic_tac_toe_AI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // o is the maximizer, x is the minimizer
            string str = "3/3/3 x";
            Console.WriteLine(str);
            while (!T3Board.IsGameFinished(FENExtractor.ExtractFEN(str)))
            {
                str = AIMovePicker.FindBestMove(str, !FENExtractor.ExtractFEN(str).isXToPlay);
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}