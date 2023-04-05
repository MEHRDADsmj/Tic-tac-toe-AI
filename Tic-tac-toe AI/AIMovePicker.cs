using System;
using System.Collections.Generic;

namespace Tic_tac_toe_AI
{
    public static class AIMovePicker
    {
        public static string FindBestMove(string currentFEN, int maxDepth, bool isMaximizer)
        {
            T3Board currentBoard = FENExtractor.ExtractFEN(currentFEN);
            T3Board bestMove = null;
            
            // Do AI stuff
            bestMove = EvaluateBoardMove(currentBoard, 0, maxDepth, isMaximizer);

            return FENExtractor.ExportFEN(bestMove);
        }

        public static T3Board EvaluateBoardMove(T3Board currentBoard, int depth, int maxDepth, bool isMaximizer)
        {
            if (depth >= maxDepth || T3Board.IsGameFinished(currentBoard))
            {
                return currentBoard;
            }
            
            if (isMaximizer) // is o
            {
                List<T3Board> nextMoves = T3Board.GetNextMoves(currentBoard, 'o');
                T3Board bestMove = FENExtractor.ExtractFEN("xxx/3/3 x");
                foreach (var boardState in nextMoves)
                {
                    T3Board b = EvaluateBoardMove(boardState, depth + 1, maxDepth, false);
                    if (Evaluator.EvaluateBoard(b) - depth >= Evaluator.EvaluateBoard(bestMove))
                    {
                        bestMove = boardState;
                    }
                }
                return bestMove;
            }
            else // is x
            {
                List<T3Board> nextMoves = T3Board.GetNextMoves(currentBoard, 'x');
                T3Board bestMove = FENExtractor.ExtractFEN("ooo/3/3 o");
                foreach (var boardState in nextMoves)
                {
                    T3Board b = EvaluateBoardMove(boardState, depth + 1, maxDepth, true);
                    if (Evaluator.EvaluateBoard(b) + depth <= Evaluator.EvaluateBoard(bestMove))
                    {
                        bestMove = boardState;
                    }
                }
                return bestMove;
            }
        }
    }
}