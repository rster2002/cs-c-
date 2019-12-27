using Quick.Input;
using System;

namespace Chess {
    class Program {
        Input input = new Input();

        static void Main(string[] args) {
            Program program = new Program();
            program.start();

            Main(args); // For testing
        }

        void start() {
            ChessGame game = new ChessGame();

            game.placeChessPieces();

            playChessGame(game);

            Console.ReadKey();
        }

        void playChessGame(ChessGame game) {
            while (true) {
                Console.Clear();

                game.printChessBoard();

                Console.WriteLine("Move chesspiece from");
                Position fromPosition = readPosition();

                Console.WriteLine();

                Console.WriteLine("Move chesspiece to");
                Position toPosition = readPosition();

                Console.WriteLine();

                try {
                    game.doMove(fromPosition, toPosition);
                } catch (Exception exception) {
                    Console.WriteLine(exception.Message);
                    Console.ReadKey();
                }
            }
        }

        Position positionStringToPosition(string positionString) {
            try {
                int column = positionString[0] - 'A';
                int row = int.Parse(positionString[1].ToString()) - 1;

                bool columnValidRange = column >= 0 && column <= 7;
                bool rowValidRange = row >= 0 && row <= 7;

                if (columnValidRange && rowValidRange) {
                    return new Position(row: row, column: column);
                } else {
                    throw new Exception();
                }
            } catch(Exception exception) {
                throw exception;
            }
        }

        bool validPositionString(string positionString) {
            try {
                positionStringToPosition(positionString);
            } catch {
                return false;
            }

            return true;
        }

        Position readPosition() {
            string positionInput = input.readString(
                "Type a board position: ",
                "This is not a valid board position",
                input => validPositionString(input)
            );

            return positionStringToPosition(positionInput);
        }
    }
}
