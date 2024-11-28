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
            Console.WriteLine("    h f g e d c b a \n");
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

        public void MovePiece()
        {
            Console.WriteLine("What piece do you want to move?");
            String origin = Console.ReadLine();
            Console.WriteLine("Where do you want to move this piece?");
            String position = Console.ReadLine();

            // Lasse: The starting location of the piece
            int originX = 0, originY = 0;

            switch (origin)
            {
                case "a1":
                    originY = 7; originX = 0; break;
                case "a2":
                    originY = 7; originX = 1; break;
                case "a3":
                    originY = 7; originX = 2; break;
                case "a4":
                    originY = 7; originX = 3; break;
                case "a5":
                    originY = 7; originX = 4; break;
                case "a6":
                    originY = 7; originX = 5; break;
                case "a7":
                    originY = 7; originX = 6; break;
                case "a8":
                    originY = 7; originX = 7; break;
                case "b1":
                    originY = 6; originX = 0; break;
                case "b2":
                    originY = 6; originX = 1; break;
                case "b3":
                    originY = 6; originX = 2; break;
                case "b4":
                    originY = 6; originX = 3; break;
                case "b5":
                    originY = 6; originX = 4; break;
                case "b6":
                    originY = 6; originX = 5; break;
                case "b7":
                    originY = 6; originX = 6; break;
                case "b8":
                    originY = 6; originX = 7; break;
                case "c1":
                    originY = 5; originX = 0; break;
                case "c2":
                    originY = 5; originX = 1; break;
                case "c3":
                    originY = 5; originX = 2; break;
                case "c4":
                    originY = 5; originX = 3; break;
                case "c5":
                    originY = 5; originX = 4; break;
                case "c6":
                    originY = 5; originX = 5; break;
                case "c7":
                    originY = 5; originX = 6; break;
                case "c8":
                    originY = 5; originX = 7; break;
                case "d1":
                    originY = 4; originX = 0; break;
                case "d2":
                    originY = 4; originX = 1; break;
                case "d3":
                    originY = 4; originX = 2; break;
                case "d4":
                    originY = 4; originX = 3; break;
                case "d5":
                    originY = 4; originX = 4; break;
                case "d6":
                    originY = 4; originX = 5; break;
                case "d7":
                    originY = 4; originX = 6; break;
                case "d8":
                    originY = 4; originX = 7; break;
                case "e1":
                    originY = 3; originX = 0; break;
                case "e2":
                    originY = 3; originX = 1; break;
                case "e3":
                    originY = 3; originX = 2; break;
                case "e4":
                    originY = 3; originX = 3; break;
                case "e5":
                    originY = 3; originX = 4; break;
                case "e6":
                    originY = 3; originX = 5; break;
                case "e7":
                    originY = 3; originX = 6; break;
                case "e8":
                    originY = 3; originX = 7; break;
                case "f1":
                    originY = 2; originX = 0; break;
                case "f2":
                    originY = 2; originX = 1; break;
                case "f3":
                    originY = 2; originX = 2; break;
                case "f4":
                    originY = 2; originX = 3; break;
                case "f5":
                    originY = 2; originX = 4; break;
                case "f6":
                    originY = 2; originX = 5; break;
                case "f7":
                    originY = 2; originX = 6; break;
                case "f8":
                    originY = 2; originX = 7; break;
                case "g1":
                    originY = 1; originX = 0; break;
                case "g2":
                    originY = 1; originX = 1; break;
                case "g3":
                    originY = 1; originX = 2; break;
                case "g4":
                    originY = 1; originX = 3; break;
                case "g5":
                    originY = 1; originX = 4; break;
                case "g6":
                    originY = 1; originX = 5; break;
                case "g7":
                    originY = 1; originX = 6; break;
                case "g8":
                    originY = 1; originX = 7; break;
                case "h1":
                    originY = 0; originX = 0; break;
                case "h2":
                    originY = 0; originX = 1; break;
                case "h3":
                    originY = 0; originX = 2; break;
                case "h4":
                    originY = 0; originX = 3; break;
                case "h5":
                    originY = 0; originX = 4; break;
                case "h6":
                    originY = 0; originX = 5; break;
                case "h7":
                    originY = 0; originX = 6; break;
                case "h8":
                    originY = 0; originX = 7; break;
                default:
                    break;
            }

            // Lasse: The end location of the piece
            int positionY = 0, positionX = 0;

            switch (position)
            {
                case "a1":
                    positionY = 7; positionX = 0; break;
                case "a2":
                    positionY = 7; positionX = 1; break;
                case "a3":
                    positionY = 7; positionX = 2; break;
                case "a4":
                    positionY = 7; positionX = 3; break;
                case "a5":
                    positionY = 7; positionX = 4; break;
                case "a6":
                    positionY = 7; positionX = 5; break;
                case "a7":
                    positionY = 7; positionX = 6; break;
                case "a8":
                    positionY = 7; positionX = 7; break;
                case "b1":
                    positionY = 6; positionX = 0; break;
                case "b2":
                    positionY = 6; positionX = 1; break;
                case "b3":
                    positionY = 6; positionX = 2; break;
                case "b4":
                    positionY = 6; positionX = 3; break;
                case "b5":
                    positionY = 6; positionX = 4; break;
                case "b6":
                    positionY = 6; positionX = 5; break;
                case "b7":
                    positionY = 6; positionX = 6; break;
                case "b8":
                    positionY = 6; positionX = 7; break;
                case "c1":
                    positionY = 5; positionX = 0; break;
                case "c2":
                    positionY = 5; positionX = 1; break;
                case "c3":
                    positionY = 5; positionX = 2; break;
                case "c4":
                    positionY = 5; positionX = 3; break;
                case "c5":
                    positionY = 5; positionX = 4; break;
                case "c6":
                    positionY = 5; positionX = 5; break;
                case "c7":
                    positionY = 5; positionX = 6; break;
                case "c8":
                    positionY = 5; positionX = 7; break;
                case "d1":
                    positionY = 4; positionX = 0; break;
                case "d2":
                    positionY = 4; positionX = 1; break;
                case "d3":
                    positionY = 4; positionX = 2; break;
                case "d4":
                    positionY = 4; positionX = 3; break;
                case "d5":
                    positionY = 4; positionX = 4; break;
                case "d6":
                    positionY = 4; positionX = 5; break;
                case "d7":
                    positionY = 4; positionX = 6; break;
                case "d8":
                    positionY = 4; positionX = 7; break;
                case "e1":
                    positionY = 3; positionX = 0; break;
                case "e2":
                    positionY = 3; positionX = 1; break;
                case "e3":
                    positionY = 3; positionX = 2; break;
                case "e4":
                    positionY = 3; positionX = 3; break;
                case "e5":
                    positionY = 3; positionX = 4; break;
                case "e6":
                    positionY = 3; positionX = 5; break;
                case "e7":
                    positionY = 3; positionX = 6; break;
                case "e8":
                    positionY = 3; positionX = 7; break;
                case "f1":
                    positionY = 2; positionX = 0; break;
                case "f2":
                    positionY = 2; positionX = 1; break;
                case "f3":
                    positionY = 2; positionX = 2; break;
                case "f4":
                    positionY = 2; positionX = 3; break;
                case "f5":
                    positionY = 2; positionX = 4; break;
                case "f6":
                    positionY = 2; positionX = 5; break;
                case "f7":
                    positionY = 2; positionX = 6; break;
                case "f8":
                    positionY = 2; positionX = 7; break;
                case "g1":
                    positionY = 1; positionX = 0; break;
                case "g2":
                    positionY = 1; positionX = 1; break;
                case "g3":
                    positionY = 1; positionX = 2; break;
                case "g4":
                    positionY = 1; positionX = 3; break;
                case "g5":
                    positionY = 1; positionX = 4; break;
                case "g6":
                    positionY = 1; positionX = 5; break;
                case "g7":
                    positionY = 1; positionX = 6; break;
                case "g8":
                    positionY = 1; positionX = 7; break;
                case "h1":
                    positionY = 0; positionX = 0; break;
                case "h2":
                    positionY = 0; positionX = 1; break;
                case "h3":
                    positionY = 0; positionX = 2; break;
                case "h4":
                    positionY = 0; positionX = 3; break;
                case "h5":
                    positionY = 0; positionX = 4; break;
                case "h6":
                    positionY = 0; positionX = 5; break;
                case "h7":
                    positionY = 0; positionX = 6; break;
                case "h8":
                    positionY = 0; positionX = 7; break;
                default:
                    break;
            }

            board[positionX, positionY] = board[originX, originY];

            Console.WriteLine(board[positionX, positionY]);
            board[originX, originY] = '-';
            }
        }
        
      
    }


