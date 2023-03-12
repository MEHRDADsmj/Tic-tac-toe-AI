using System.Collections.Generic;

namespace Tic_tac_toe_AI
{
    public class Board
    {
        public List<char> board = new List<char>();
        public bool isXToPlay = true;

        public Board()
        {
            for (int index = 0; index < 9; ++index)
            {
                board.Add('+');
            }
        }
    }
    
    public static class FENExtractor
    {
        public static Board ExtractFEN(string FEN)
        {
            Board b = new Board();
            int row = 0;
            int boardIndex = 0;
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
                            for (int index2 = 0; index2 < number; ++index2)
                            {
                                b.board[boardIndex] = '_';
                                boardIndex++;
                            }
                        }
                        break;
                }
            }

            return b;
        }
    }
}