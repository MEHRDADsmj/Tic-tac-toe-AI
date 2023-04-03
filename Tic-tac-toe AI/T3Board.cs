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
}