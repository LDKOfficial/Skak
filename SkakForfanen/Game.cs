using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkakForfanen
{
    internal class Game
    {
        // Ian: Creates a new board
        Board board = new Board();

        // Ian: Handles The startup of the program
        public void StartUp()
        {
            board.Setup();
            Move();
        }

        // Ian: Asks the user if they wanna continue
        public void Continue()
        {
            
            Console.WriteLine("Do you wanna continue Write 1 if yes and 2 if no");
            int answer = Convert.ToInt16(Console.ReadLine());
            // Ian: Checks the answer of the user
            if (answer == 1) 
            {
                Console.Clear();
                Move();
            }
            else
            {
                return;
            }
        }

        // Ian: Handles the majority of the game, which includes the useres input of moves,
        // printing the board, and moving the pieces.
        public void Move()
        {
            board.PrintBoard();

            // Ian: Gets the users input
            string origin = GetOrigin();
            int[] originInt = ConvertChessNotationToArrayNotation(origin);
            string position = GetPosition();
            int[] positionInt = ConvertChessNotationToArrayNotation(position);

            // Ian: Validates the move
            bool validation = board.CheckRules(originInt, positionInt);
            // Ian: If true moves the piece and prints the board, then continues
            if (validation)
            {
                board.MovePiece(originInt, positionInt);
                board.PrintBoard();
                Continue();
            }
            // Ian: Otherwise gets a new input
            else
            {
                Console.Clear();
                Console.WriteLine("The move was invalid \n");
                Move();
            }
            
        }

        // Ian: Gets the users input for what piece to move
        public string GetOrigin()
        {
            Console.WriteLine("What piece do you want to move?");
            String origin = Console.ReadLine();
            return origin;
        }

        // Ian: Gets the potition of where to move the piece
        private string GetPosition()
        {
            Console.WriteLine("Where do you want to move this piece?");
            String position = Console.ReadLine();
            return position;
        }

        // Ian: Converts The users input to usabel variabels 
        private int[] ConvertChessNotationToArrayNotation(string chessNotation)
        {
            // Ian: The starting location of the piece
            int arrayNotationX = 0, arrayNotationY = 0;

            // Ian: Converts each individual space to a usabel info
            switch (chessNotation)
            {
                case "a1":
                    arrayNotationY = 7; arrayNotationX = 0; break;
                case "a2":
                    arrayNotationY = 7; arrayNotationX = 1; break;
                case "a3":
                    arrayNotationY = 7; arrayNotationX = 2; break;
                case "a4":
                    arrayNotationY = 7; arrayNotationX = 3; break;
                case "a5":
                    arrayNotationY = 7; arrayNotationX = 4; break;
                case "a6":
                    arrayNotationY = 7; arrayNotationX = 5; break;
                case "a7":
                    arrayNotationY = 7; arrayNotationX = 6; break;
                case "a8":
                    arrayNotationY = 7; arrayNotationX = 7; break;
                case "b1":
                    arrayNotationY = 6; arrayNotationX = 0; break;
                case "b2":
                    arrayNotationY = 6; arrayNotationX = 1; break;
                case "b3":
                    arrayNotationY = 6; arrayNotationX = 2; break;
                case "b4":
                    arrayNotationY = 6; arrayNotationX = 3; break;
                case "b5":
                    arrayNotationY = 6; arrayNotationX = 4; break;
                case "b6":
                    arrayNotationY = 6; arrayNotationX = 5; break;
                case "b7":
                    arrayNotationY = 6; arrayNotationX = 6; break;
                case "b8":
                    arrayNotationY = 6; arrayNotationX = 7; break;
                case "c1":
                    arrayNotationY = 5; arrayNotationX = 0; break;
                case "c2":
                    arrayNotationY = 5; arrayNotationX = 1; break;
                case "c3":
                    arrayNotationY = 5; arrayNotationX = 2; break;
                case "c4":
                    arrayNotationY = 5; arrayNotationX = 3; break;
                case "c5":
                    arrayNotationY = 5; arrayNotationX = 4; break;
                case "c6":
                    arrayNotationY = 5; arrayNotationX = 5; break;
                case "c7":
                    arrayNotationY = 5; arrayNotationX = 6; break;
                case "c8":
                    arrayNotationY = 5; arrayNotationX = 7; break;
                case "d1":
                    arrayNotationY = 4; arrayNotationX = 0; break;
                case "d2":
                    arrayNotationY = 4; arrayNotationX = 1; break;
                case "d3":
                    arrayNotationY = 4; arrayNotationX = 2; break;
                case "d4":
                    arrayNotationY = 4; arrayNotationX = 3; break;
                case "d5":
                    arrayNotationY = 4; arrayNotationX = 4; break;
                case "d6":
                    arrayNotationY = 4; arrayNotationX = 5; break;
                case "d7":
                    arrayNotationY = 4; arrayNotationX = 6; break;
                case "d8":
                    arrayNotationY = 4; arrayNotationX = 7; break;
                case "e1":
                    arrayNotationY = 3; arrayNotationX = 0; break;
                case "e2":
                    arrayNotationY = 3; arrayNotationX = 1; break;
                case "e3":
                    arrayNotationY = 3; arrayNotationX = 2; break;
                case "e4":
                    arrayNotationY = 3; arrayNotationX = 3; break;
                case "e5":
                    arrayNotationY = 3; arrayNotationX = 4; break;
                case "e6":
                    arrayNotationY = 3; arrayNotationX = 5; break;
                case "e7":
                    arrayNotationY = 3; arrayNotationX = 6; break;
                case "e8":
                    arrayNotationY = 3; arrayNotationX = 7; break;
                case "f1":
                    arrayNotationY = 2; arrayNotationX = 0; break;
                case "f2":
                    arrayNotationY = 2; arrayNotationX = 1; break;
                case "f3":
                    arrayNotationY = 2; arrayNotationX = 2; break;
                case "f4":
                    arrayNotationY = 2; arrayNotationX = 3; break;
                case "f5":
                    arrayNotationY = 2; arrayNotationX = 4; break;
                case "f6":
                    arrayNotationY = 2; arrayNotationX = 5; break;
                case "f7":
                    arrayNotationY = 2; arrayNotationX = 6; break;
                case "f8":
                    arrayNotationY = 2; arrayNotationX = 7; break;
                case "g1":
                    arrayNotationY = 1; arrayNotationX = 0; break;
                case "g2":
                    arrayNotationY = 1; arrayNotationX = 1; break;
                case "g3":
                    arrayNotationY = 1; arrayNotationX = 2; break;
                case "g4":
                    arrayNotationY = 1; arrayNotationX = 3; break;
                case "g5":
                    arrayNotationY = 1; arrayNotationX = 4; break;
                case "g6":
                    arrayNotationY = 1; arrayNotationX = 5; break;
                case "g7":
                    arrayNotationY = 1; arrayNotationX = 6; break;
                case "g8":
                    arrayNotationY = 1; arrayNotationX = 7; break;
                case "h1":
                    arrayNotationY = 0; arrayNotationX = 0; break;
                case "h2":
                    arrayNotationY = 0; arrayNotationX = 1; break;
                case "h3":
                    arrayNotationY = 0; arrayNotationX = 2; break;
                case "h4":
                    arrayNotationY = 0; arrayNotationX = 3; break;
                case "h5":
                    arrayNotationY = 0; arrayNotationX = 4; break;
                case "h6":
                    arrayNotationY = 0; arrayNotationX = 5; break;
                case "h7":
                    arrayNotationY = 0; arrayNotationX = 6; break;
                case "h8":
                    arrayNotationY = 0; arrayNotationX = 7; break;
                default:
                    break;
            }

            int[] arrayNotation = { arrayNotationX, arrayNotationY };
            return arrayNotation;
        }

    }
}
