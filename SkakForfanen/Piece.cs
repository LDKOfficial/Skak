using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkakForfanen
{
    internal class Piece
    {

        // Lasse: 0 is white. 1 is black. 
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

        private char icon;
        public char Icon
        {
            get { return icon; }
        }

        // Kat: Constructer
        public Piece(int colorInput, string typeInput)
        {
            color = colorInput;
            type = typeInput;

            // Kat: sets the pointValue for the coresponding type. 
            // Kat: Uppercase letters are black, while Lowercase are white
            switch (type)
            {
                case "Pawn":
                {
                    pointValue = 1;
                        if (colorInput == 0)
                        {
                            icon = 'p';
                        }
                        else
                        {
                            icon = 'P';
                        }
                    break;
                }
                case "Bishop":
                {
                    pointValue = 3;
                        if (colorInput == 0)
                        {
                            icon = 'b';
                        }
                        else
                        {
                            icon = 'B';
                        }
                        break;
                }
                case "Knight":
                {
                    pointValue = 3;
                        if (colorInput == 0)
                        {
                            icon = 'h';
                        }
                        else
                        {
                            icon = 'H';
                        }
                        break;
                }
                case "Rook":
                {
                    pointValue = 5;
                        if (colorInput == 0)
                        {
                            icon = 'r';
                        }
                        else
                        {
                            icon = 'R';
                        }
                        break;
                }
                case "Queen":
                {  
                    pointValue = 9;
                        if (colorInput == 0)
                        {
                            icon = 'q';
                        }
                        else
                        {
                            icon = 'Q';
                        }
                        break;
                }
                case "King":
                {
                    pointValue = 0;
                        if (colorInput == 0)
                        {
                            icon = 'k';
                        }
                        else
                        {
                            icon = 'K';
                        }
                        break;
                }
                default:
                {
                    pointValue = 0;
                    icon = '-';
                    break;
                }
        }
    }



}
}
