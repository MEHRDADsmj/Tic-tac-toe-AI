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
            if (b.GetAt(0) == b.GetAt(1) && b.GetAt(1) == b.GetAt(2) && b.GetAt(0) != '_')
            {
                isX = b.GetAt(0) == 'x';
                return true;
            }
            else if (b.GetAt(3) == b.GetAt(4) && b.GetAt(4) == b.GetAt(5) && b.GetAt(3) != '_')
            {
                isX = b.GetAt(3) == 'x';
                return true;
            }
            else if (b.GetAt(6) == b.GetAt(7) && b.GetAt(7) == b.GetAt(8) && b.GetAt(6) != '_')
            {
                isX = b.GetAt(6) == 'x';
                return true;
            }

            return false;
        }

        private static bool CheckCols(T3Board b, out bool isX)
        {
            isX = false;
            if (b.GetAt(0) == b.GetAt(3) && b.GetAt(3) == b.GetAt(6) && b.GetAt(0) != '_')
            {
                isX = b.GetAt(0) == 'x';
                return true;
            }
            else if (b.GetAt(1) == b.GetAt(4) && b.GetAt(4) == b.GetAt(7) && b.GetAt(1) != '_')
            {
                isX = b.GetAt(1) == 'x';
                return true;
            }
            else if (b.GetAt(2) == b.GetAt(5) && b.GetAt(5) == b.GetAt(8) && b.GetAt(2) != '_')
            {
                isX = b.GetAt(2) == 'x';
                return true;
            }

            return false;
        }
        
        private static bool CheckDiagonally(T3Board b, out bool isX)
        {
            isX = false;
            if (b.GetAt(0) == b.GetAt(4) && b.GetAt(4) == b.GetAt(8) && b.GetAt(0) != '_')
            {
                isX = b.GetAt(0) == 'x';
                return true;
            }
            else if (b.GetAt(2) == b.GetAt(4) && b.GetAt(4) == b.GetAt(6) && b.GetAt(2) != '_')
            {
                isX = b.GetAt(2) == 'x';
                return true;
            }

            return false;
        }
    }
}