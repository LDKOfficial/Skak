using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkakForfanen;

namespace SkakForfanen
{
    internal class Board
    {
        Piece hej = new Piece(1, "hej");
        Piece hej2 = new Piece(1, "hej");
        Piece hej3 = new Piece(1, "hej");
        Piece hej4 = new Piece(1, "hej");

        // Ian: skal muligvis være en anden array type
        public Piece[,] boards =
        {
            {hej, hej2 },
            {hej3, hej4 }

        };
    }
}
