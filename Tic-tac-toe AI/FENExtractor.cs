using System;
using System.Collections.Generic;

namespace Tic_tac_toe_AI
{
    public static class FENExtractor
    {
        public static T3Board ExtractFEN(string FEN)
        {
            T3Board b = new T3Board();
            ParseFEN(FEN, b);

            return b;
        }

        public static string ExportFEN(T3Board b)
        {
            string FEN = "";
            for (int row = 0; row < 3; ++row)
            {
                int emptyCounter = 0;
                for (int col = 0; col < 3; ++col)
                {
                    int index = row * 3 + col;
                    if (b.board[index] == '_')
                    {
                        ++emptyCounter;
                    }
                    else
                    {
                        if (emptyCounter != 0)
                        {
                            FEN += emptyCounter.ToString();
                            emptyCounter = 0;
                        }

                        FEN += b.board[index];
                    }
                }
                
                if (emptyCounter != 0)
                {
                    FEN += emptyCounter.ToString();
                }

                if (row != 2)
                {
                    FEN += '/';
                }
            }

            FEN += " ";
            FEN += b.isXToPlay ? "x" : "o";
            return FEN;
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