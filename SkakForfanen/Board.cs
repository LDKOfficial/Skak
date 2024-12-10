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
        // Someone: Row 8
        Piece a8 = new Piece(1, "Rook");
        Piece b8 = new Piece(1, "Knight");
        Piece c8 = new Piece(1, "Bishop");
        Piece d8 = new Piece(1, "Queen");
        Piece e8 = new Piece(1, "King");
        Piece f8 = new Piece(1, "Bishop");
        Piece g8 = new Piece(1, "Knight");
        Piece h8 = new Piece(1, "Rook");

        // Someone: Row 7
        Piece a7 = new Piece(1, "Pawn");
        Piece b7 = new Piece(1, "Pawn");
        Piece c7 = new Piece(1, "Pawn");
        Piece d7 = new Piece(1, "Pawn");
        Piece e7 = new Piece(1, "Pawn");
        Piece f7 = new Piece(1, "Pawn");
        Piece g7 = new Piece(1, "Pawn");
        Piece h7 = new Piece(1, "Pawn");

        // Someone: Row 6
        Piece a6 = new Piece(0, "Blank");
        Piece b6 = new Piece(1, "Blank");
        Piece c6 = new Piece(0, "Blank");
        Piece d6 = new Piece(1, "Blank");
        Piece e6 = new Piece(0, "Blank");
        Piece f6 = new Piece(1, "Blank");
        Piece g6 = new Piece(0, "Blank");
        Piece h6 = new Piece(1, "Blank");

        // Someone: Row 5
        Piece a5 = new Piece(1, "Blank");
        Piece b5 = new Piece(0, "Blank");
        Piece c5 = new Piece(1, "Blank");
        Piece d5 = new Piece(0, "Blank");
        Piece e5 = new Piece(1, "Blank");
        Piece f5 = new Piece(0, "Blank");
        Piece g5 = new Piece(1, "Blank");
        Piece h5 = new Piece(0, "Blank");

        // Someone: Row 4
        Piece a4 = new Piece(0, "Blank");
        Piece b4 = new Piece(1, "Blank");
        Piece c4 = new Piece(0, "Blank");
        Piece d4 = new Piece(1, "Blank");
        Piece e4 = new Piece(0, "Blank");
        Piece f4 = new Piece(1, "Blank");
        Piece g4 = new Piece(0, "Blank");
        Piece h4 = new Piece(1, "Blank");

        // Someone: Row 3
        Piece a3 = new Piece(1, "Blank");
        Piece b3 = new Piece(0, "Blank");
        Piece c3 = new Piece(1, "Blank");
        Piece d3 = new Piece(0, "Blank");
        Piece e3 = new Piece(1, "Blank");
        Piece f3 = new Piece(0, "Blank");
        Piece g3 = new Piece(1, "Blank");
        Piece h3 = new Piece(0, "Blank");

        // Someone: Row 2
        Piece a2 = new Piece(0, "Pawn");
        Piece b2 = new Piece(0, "Pawn");
        Piece c2 = new Piece(0, "Pawn");
        Piece d2 = new Piece(0, "Pawn");
        Piece e2 = new Piece(0, "Pawn");
        Piece f2 = new Piece(0, "Pawn");
        Piece g2 = new Piece(0, "Pawn");
        Piece h2 = new Piece(0, "Pawn");

        // Someone: Row 1
        Piece a1 = new Piece(0, "Rook");
        Piece b1 = new Piece(0, "Knight");
        Piece c1 = new Piece(0, "Bishop");
        Piece d1 = new Piece(0, "King");
        Piece e1 = new Piece(0, "Queen");
        Piece f1 = new Piece(0, "Bishop");
        Piece g1 = new Piece(0, "Knight");
        Piece h1 = new Piece(0, "Rook");


        char[,] board = new char[8,8];
        
        public void Setup()
        {
            board[0, 0] = a8.Icon; board[0, 1] = b8.Icon; board[0, 2] = c8.Icon; board[0, 3] = d8.Icon; board[0, 4] = e8.Icon; board[0, 5] = f8.Icon; board[0, 6] = g8.Icon; board[0, 7] = h8.Icon;
            board[1, 0] = a7.Icon; board[1, 1] = b7.Icon; board[1, 2] = c7.Icon; board[1, 3] = d7.Icon; board[1, 4] = e7.Icon; board[1, 5] = f7.Icon; board[1, 6] = g7.Icon; board[1, 7] = h7.Icon;
            board[2, 0] = a6.Icon; board[2, 1] = b6.Icon; board[2, 2] = c6.Icon; board[2, 3] = d6.Icon; board[2, 4] = e6.Icon; board[2, 5] = f6.Icon; board[2, 6] = g6.Icon; board[2, 7] = h6.Icon;
            board[3, 0] = a5.Icon; board[3, 1] = b5.Icon; board[3, 2] = c5.Icon; board[3, 3] = d5.Icon; board[3, 4] = e5.Icon; board[3, 5] = f5.Icon; board[3, 6] = g5.Icon; board[3, 7] = h5.Icon;
            board[4, 0] = a4.Icon; board[4, 1] = b4.Icon; board[4, 2] = c4.Icon; board[4, 3] = d4.Icon; board[4, 4] = e4.Icon; board[4, 5] = f4.Icon; board[4, 6] = g4.Icon; board[4, 7] = h4.Icon;
            board[5, 0] = a3.Icon; board[5, 1] = b3.Icon; board[5, 2] = c3.Icon; board[5, 3] = d3.Icon; board[5, 4] = e3.Icon; board[5, 5] = f3.Icon; board[5, 6] = g3.Icon; board[5, 7] = h3.Icon;
            board[6, 0] = a2.Icon; board[6, 1] = b2.Icon; board[6, 2] = c2.Icon; board[6, 3] = d2.Icon; board[6, 4] = e2.Icon; board[6, 5] = f2.Icon; board[6, 6] = g2.Icon; board[6, 7] = h2.Icon;
            board[7, 0] = a1.Icon; board[7, 1] = b1.Icon; board[7, 2] = c1.Icon; board[7, 3] = d1.Icon; board[7, 4] = e1.Icon; board[7, 5] = f1.Icon; board[7, 6] = g1.Icon; board[7, 7] = h1.Icon;

        }

        public void PrintBoard()
        {
            Console.WriteLine("    h g f e d c b a \n");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                int row = 0;
                switch (i)
                {
                    case 0:
                        row = 1; break;
                    case 1:
                        row = 2; break;
                    case 2:
                        row = 3; break;
                    case 3:
                        row = 4; break;
                    case 4:
                        row = 5; break;
                    case 5:
                        row = 6; break;
                    case 6:
                        row = 7; break;
                    case 7:
                        row = 8; break;
                }
                Console.WriteLine($"{row}   {board[i, 0]} {board[i, 1]} {board[i, 2]} {board[i, 3]} {board[i, 4]} {board[i, 5]} {board[i, 6]} {board[i, 7]}");
            }
        }

        public void MovePiece(int[] origin, int[] position)
        {
            int originX = origin[0], originY = origin[1];
            int positionX = position[0], positionY = position[1];

            board[positionX, positionY] = board[originX, originY];

            Console.WriteLine(board[positionX, positionY]);
            board[originX, originY] = '-';


            // Lasse: Check regler to be done
        }

        // Kat: Rules logic
        public bool CheckRules(int[] origin, int[] position)
        {
            bool validation = false;
            int originX = origin[0], originY = origin[1];
            int positionX = position[0], positionY = position[1];


            // Kat: Checks if white pawn Moves correctly
            if (board[originX, originY] == 'p')
            {
                if (originY == positionY && originX - positionX == 1)
                {
                    validation = true;
                }
            }
            // Kat: Checks if black pawn moves correctly
            else if (board[originX, originY] == 'P')
            {
                if (originY == positionY && positionX - originX == 1)
                {
                    validation = true;
                }
            }
            // Kat: Checks if rook moves correctly
            else if (board[originX, originY] == 'R' || board[originX, originY] == 'r')
            {
                if (originX == positionX && !(positionY == originY))
                {
                    validation = true;
                }
                else if (!(originX == positionX) && positionY == originY)
                {
                    validation = true;
                }
            }
            // Kat: Checks if bishop moves correctly
            else if (board[originX, originY] == 'B' || board[originX, originY] == 'b')
            {
                if (positionX - originX == positionY - originY)
                {
                    validation = true;
                }
                else if (positionX - originX == originY - positionY)
                {
                    validation = true;
                }
            }
            // Kat: Checks if knight moves correctly
            else if (board[originX, originY] == 'H' || board[originX, originY] == 'h')
            {
                if (originY - positionY == 1 && positionX - originX == 2)
                {
                    validation = true;
                }
                else if (positionY - originY == 1 && positionX - originX == 2)
                {
                    validation = true;
                }
                else if (originY - positionY == 1 && originX - positionX == 2)
                {
                    validation = true;
                }
                else if (positionY - originY == 1 && originX - positionX == 2)
                {
                    validation = true;
                }
                else if (positionY - originY == 2 && positionX - originX == 1)
                {
                    validation = true;
                }
                else if (originY - positionY == 2 && positionX - originX == 1)
                {
                    validation = true;
                }
                else if (originY - positionY == 2 && originX - positionX == 1)
                {
                    validation = true;
                }
                else if(positionY - originY == 2 && originX - positionX == 1)
                {
                    validation = true;
                }
            }

            else if (board[originX, originY] == 'Q' || board[originX, originY] == 'q')
            {
                if (positionX - originX == positionY - originY)
                {
                    validation = true;
                }
                else if (positionX - originX == originY - positionY)
                {
                    validation = true;
                }
                else if (originX == positionX && !(positionY == originY))
                {
                    validation = true;
                }
                else if (!(originX == positionX) && positionY == originY)
                {
                    validation = true;
                }
            }
            return validation;
        }
    }     
}


