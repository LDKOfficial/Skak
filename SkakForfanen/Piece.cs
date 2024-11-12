using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkakForfanen
{
    internal class Piece
    {

        // Lasse: 0 is white. 1 is black
        private int color;
        public int Color
        {
            get { return color; }
        }

        private string type;
        public string Type
        {
            get { return type; }
        }

        private int pointValue;
        public int PointValue 
        {
            get { return pointValue; }
        }

        // Lasse: Constructer
        public Piece(int colorInput, string typeInput)
        {
            color = colorInput;
            type = typeInput;

            // Lasse: sets the pointValue for the coresponding type.
            switch (type)
            {
                case "Pawn":
                {
                    pointValue = 1;
                    break;
                }
                case "Bishop":
                {
                    pointValue = 3;
                    break;
                }
                case "Knight":
                {
                    pointValue = 3;
                    break;
                }
                case "Rook":
                {
                    pointValue = 5;
                    break;
                }
                case "Queen":
                {  
                    pointValue = 9; 
                    break;
                }
                default:
                {
                    pointValue = 0;
                    break;
                }
        }
    }



}
}
