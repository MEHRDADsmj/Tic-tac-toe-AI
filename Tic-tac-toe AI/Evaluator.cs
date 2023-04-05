namespace Tic_tac_toe_AI
{
    public static class Evaluator
    {
        /// <summary>
        /// returns a value to show if a player wins. -10 means 'x' won, 10 means 'o' won, 0 means draw
        /// </summary>
        /// <param name="b">Board to be Evaluated</param>
        /// <returns>Board score</returns>
        public static int EvaluateBoard(T3Board b)
        {
            bool isXWinning;
            if (CheckRows(b, out isXWinning) || CheckCols(b, out isXWinning) || CheckDiagonally(b, out isXWinning))
            {
                return isXWinning ? -10 : 10;
            }

            return 0;
        }

        private static bool CheckRows(T3Board b, out bool isX)
        {
            isX = false;
            if (b.board[0] == b.board[1] && b.board[1] == b.board[2] && b.board[0] != '_')
            {
                isX = b.board[0] == 'x';
                return true;
            }
            else if (b.board[3] == b.board[4] && b.board[4] == b.board[5] && b.board[3] != '_')
            {
                isX = b.board[3] == 'x';
                return true;
            }
            else if (b.board[6] == b.board[7] && b.board[7] == b.board[8] && b.board[6] != '_')
            {
                isX = b.board[6] == 'x';
                return true;
            }

            return false;
        }

        private static bool CheckCols(T3Board b, out bool isX)
        {
            isX = false;
            if (b.board[0] == b.board[3] && b.board[3] == b.board[6] && b.board[0] != '_')
            {
                isX = b.board[0] == 'x';
                return true;
            }
            else if (b.board[1] == b.board[4] && b.board[4] == b.board[7] && b.board[1] != '_')
            {
                isX = b.board[1] == 'x';
                return true;
            }
            else if (b.board[2] == b.board[5] && b.board[5] == b.board[8] && b.board[2] != '_')
            {
                isX = b.board[2] == 'x';
                return true;
            }

            return false;
        }
        
        private static bool CheckDiagonally(T3Board b, out bool isX)
        {
            isX = false;
            if (b.board[0] == b.board[4] && b.board[4] == b.board[8] && b.board[0] != '_')
            {
                isX = b.board[0] == 'x';
                return true;
            }
            else if (b.board[2] == b.board[4] && b.board[4] == b.board[6] && b.board[2] != '_')
            {
                isX = b.board[2] == 'x';
                return true;
            }

            return false;
        }
    }
}