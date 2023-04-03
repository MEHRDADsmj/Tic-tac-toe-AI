using System;
using System.Collections.Generic;

namespace Tic_tac_toe_AI
{
    public static class AIMovePicker
    {
        public static string FindBestMove(string currentFEN)
        {
            T3Board currentBoard = FENExtractor.ExtractFEN(currentFEN);
            T3Board bestMove = null;
            
            // Do AI stuff
            bestMove = EvaluateBoardMove(currentBoard, 0, false);

            return FENExtractor.ExportFEN(bestMove);
        }

        public static T3Board EvaluateBoardMove(T3Board currentBoard, int depth, bool isMaximizer)
        {
            if (!T3Board.AreMovesLeft(currentBoard))
            {
                return currentBoard;
            }
            
            if (isMaximizer)
            {
                List<T3Board> nextMoves = T3Board.GetNextMoves(currentBoard, 'o');
                T3Board bestMove = nextMoves[0];
                foreach (var boardState in nextMoves)
                {
                    T3Board b = EvaluateBoardMove(boardState, depth + 1, false);
                    if (Evaluator.EvaluateBoard(b) - depth > Evaluator.EvaluateBoard(bestMove))
                    {
                        bestMove = b;
                    }
                }
                return bestMove;
            }
            else
            {
                List<T3Board> nextMoves = T3Board.GetNextMoves(currentBoard, 'x');
                T3Board bestMove = nextMoves[0];
                foreach (var boardState in nextMoves)
                {
                    T3Board b = EvaluateBoardMove(boardState, depth + 1, true);
                    if (Evaluator.EvaluateBoard(b) + depth < Evaluator.EvaluateBoard(bestMove))
                    {
                        bestMove = b;
                    }
                }
                return bestMove;
            }
        }
    }
}