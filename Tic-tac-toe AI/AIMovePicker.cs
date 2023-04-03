namespace Tic_tac_toe_AI
{
    public static class AIMovePicker
    {
        public static string FindBestMove(string currentFEN)
        {
            T3Board currentBoard = FENExtractor.ExtractFEN(currentFEN);
            T3Board bestMove = null;
            
            // Do AI stuff
            bestMove = EvaluateBoardMove(currentBoard);

            return FENExtractor.ExportFEN(bestMove);
        }

        public static T3Board EvaluateBoardMove(T3Board currentBoard)
        {
            T3Board bestMove = null;



            return bestMove;
        }
    }
}