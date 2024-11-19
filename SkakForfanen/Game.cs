using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkakForfanen
{
    internal class Game
    {

        Board board = new Board();
        public void StartUp()
        {
            board.Setup();
            board.PrintBoard();
        }
    }
}
