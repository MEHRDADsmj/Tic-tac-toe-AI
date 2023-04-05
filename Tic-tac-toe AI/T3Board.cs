﻿using System.Collections.Generic;

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
                board.Add('_');
            }
        }

        public T3Board(T3Board board)
        {
            foreach (var item in board.board)
            {
                this.board.Add(item);
            }

            isXToPlay = board.isXToPlay;
        }

        public static List<T3Board> GetNextMoves(T3Board currentBoard, char XO)
        {
            List<T3Board> nextPossibleMoves = new List<T3Board>();

            for (int index = 0; index < currentBoard.board.Count; ++index)
            {
                if (currentBoard.board[index] == '_')
                {
                    T3Board newBoard = new T3Board(currentBoard);
                    newBoard.isXToPlay = !currentBoard.isXToPlay;
                    newBoard.board[index] = XO;
                    nextPossibleMoves.Add(newBoard);
                }
                
            }

            return nextPossibleMoves;
        }

        public static bool AreMovesLeft(T3Board currentBoard)
        {
            foreach (var item in currentBoard.board)
            {
                if (item == '_')
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsGameFinished(T3Board currentBoard)
        {
            int score = Evaluator.EvaluateBoard(currentBoard);
            return !AreMovesLeft(currentBoard) || score != 0;
        }
    }
}