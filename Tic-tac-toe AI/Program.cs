using System;

namespace Tic_tac_toe_AI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            T3Board b = FENExtractor.ExtractFEN("3/3/3 x");
            string str = AIMovePicker.FindBestMove("3/1o1/3 o");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}