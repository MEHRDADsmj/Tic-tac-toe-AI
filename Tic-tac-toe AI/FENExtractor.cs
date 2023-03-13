using System;
using System.Collections.Generic;

namespace Tic_tac_toe_AI
{
    
    /// <summary>
    /// T3 standing for tic-tac-toe
    /// </summary>
    public class T3Board
    {
        public List<char> board = new List<char>();
        public bool isXToPlay = true;

        public T3Board()
        {
            for (int index = 0; index < 9; ++index)
            {
                board.Add('+');
            }
        }
    }
    
    public static class FENExtractor
    {
        public static T3Board ExtractFEN(string FEN)
        {
            T3Board b = new T3Board();
            ParseFEN(FEN, b);

            return b;
        }

        private static void ParseFEN(string FEN, T3Board b)
        {
            int row = 0, boardIndex = 0;
            FEN = FEN.ToLower();
            for (int index = 0; index < FEN.Length; ++index)
            {
                if (FEN[index] == '/' || FEN[index] == ' ')
                {
                    row++;
                    continue;
                }
                else if (row >= 3)
                {
                    if (FEN[index] == 'x')
                    {
                        b.isXToPlay = true;
                    }
                    else if (FEN[index] == 'o')
                    {
                        b.isXToPlay = false;
                    }

                    break;
                }

                switch (FEN[index])
                {
                    case 'x':
                        b.board[boardIndex] = 'x';
                        boardIndex++;
                        break;
                    case 'o':
                        b.board[boardIndex] = 'o';
                        boardIndex++;
                        break;
                    default:
                        int number = FEN[index] - '0';
                        if (number < 10 && number >= 0)
                        {
                            for (int counter = 0; counter < number; ++counter)
                            {
                                b.board[boardIndex] = '_';
                                boardIndex++;
                            }
                        }
                        break;
                }
            }
        }
    }
}