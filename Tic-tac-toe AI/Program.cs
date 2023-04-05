using System;

namespace Tic_tac_toe_AI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // o is the maximizer, x is the minimizer
            string str = "3/1o1/3 x";
            int depthToSearch = 10;
            Console.WriteLine(str);
            while (!T3Board.IsGameFinished(FENExtractor.ExtractFEN(str)))
            {
                str = AIMovePicker.FindBestMove(str, depthToSearch, !FENExtractor.ExtractFEN(str).isXToPlay);
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}