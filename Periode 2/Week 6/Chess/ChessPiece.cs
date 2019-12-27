namespace Chess {
    class ChessPiece {
        public ChessPieceColor color;
        public ChessPieceType type;
        public Position currentPosition;
        public char representationCharacter;

        public ChessPiece(ChessPieceColor color, ChessPieceType type, Position position) {
            this.color = color;
            this.type = type;
            currentPosition = position;
            representationCharacter = chessPeiceTypeToChar(type: type);
        }

        private char chessPeiceTypeToChar(ChessPieceType type) {
            return type.ToString()[0];
        }
    }
}
