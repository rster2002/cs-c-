using System;
using System.Collections.Generic;

namespace Chess {
    class ChessPiece {
        public char representationCharacter;
        public Position position;
        public ChessPieceColor color;
        public ChessPieceType type;

        private Func<int, int, bool> moveCheckForType;
        private Dictionary<ChessPieceType, Func<int, int, bool>> moveCheckMap = new Dictionary<ChessPieceType, Func<int, int, bool>>() {
            { ChessPieceType.Rook, (hor, ver) => hor * ver == 0 },
            { ChessPieceType.Knight, (hor, ver) => hor * ver == 2 },
            { ChessPieceType.Bishops, (hor, ver) => hor == ver },
            { ChessPieceType.King, (hor, ver) => hor == 1 || ver == 1 },
            { ChessPieceType.Queen, (hor, ver) => hor * ver == 0 || hor == ver },
            { ChessPieceType.Pawn, (hor, ver) => hor == 0 && ver == 1 }
        };

        public ChessPiece(ChessPieceColor color, ChessPieceType type, Position position) {
            this.type = type;
            this.color = color;
            this.position = position;
            moveCheckForType = moveCheckMap[type];
            representationCharacter = chessPeiceTypeToChar(type);
        }

        private char chessPeiceTypeToChar(ChessPieceType type) {
            return type.ToString()[0];
        }

        public bool validMove(Position fromPosition, Position toPosition) {
            int differenceHorizontal = Math.Abs(fromPosition.column - toPosition.column);
            int differenceVertical = Math.Abs(fromPosition.row - toPosition.row);

            return moveCheckForType(differenceHorizontal, differenceVertical);
        }
    }
}
