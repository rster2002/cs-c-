﻿using System;
using System.Collections.Generic;

namespace Chess {
    class ChessGame {
        ChessPiece[,] chessBoard = new ChessPiece[8, 8];
        Dictionary<ChessPieceType, Func<int, int, bool>> moveCheckMap = new Dictionary<ChessPieceType, Func<int, int, bool>>();

        public ChessGame() {
            fillEmptyChessBoard();

            moveCheckMap.Add(ChessPieceType.Rook, (hor, ver) => hor * ver == 0);                // Rook
            moveCheckMap.Add(ChessPieceType.Knight, (hor, ver) => hor * ver == 2);              // Knight
            moveCheckMap.Add(ChessPieceType.Bishops, (hor, ver) => hor == ver);                 // Bishop
            moveCheckMap.Add(ChessPieceType.King, (hor, ver) => hor == 1 || ver == 1);          // King
            moveCheckMap.Add(ChessPieceType.Queen, (hor, ver) => hor * ver == 0 || hor == ver); // Queen
            moveCheckMap.Add(ChessPieceType.Pawn, (hor, ver) => hor == 0 && ver == 1);          // Pawn
        }

        public void fillEmptyChessBoard() {
            for (int r = 0; r < chessBoard.GetLength(0); r++) {
                for (int c = 0; c < chessBoard.GetLength(1); c++) {
                    chessBoard[r, c] = null;
                }
            }
        }

        public void printChessBoard() {
            for (int r = 0; r < chessBoard.GetLength(0) + 1; r++) {
                if (r == 0) {
                    Console.Write("  ");

                    for (int c = 0; c < chessBoard.GetLength(1); c++) {
                        Console.Write(" {0} ", (ChessBoardColumn) c);
                    }
                } else {
                    Console.Write("{0} ", r);

                    for (int c = 0; c < chessBoard.GetLength(1); c++) {
                        ChessPiece boardPosition = chessBoard[r - 1, c];

                        if ((r + c + 1) % 2 == 0) {
                            Console.BackgroundColor = ConsoleColor.Green;
                        } else {
                            Console.BackgroundColor = ConsoleColor.White;
                        }

                        printChessBoardPosition(boardPosition);

                        Console.ResetColor();
                    }
                }

                Console.WriteLine();
            }
        }

        public void printChessBoardPosition(ChessPiece chessPiece) {
            if (chessPiece != null) {
                if (chessPiece.color == ChessPieceColor.White) {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                } else {
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.Write(" {0} ", chessPiece.representationCharacter);
            } else {
                Console.Write("   ");
            }
        }

        public void placeChessPieces() {
            ChessPieceType[] backRowPieces = {
                ChessPieceType.Rook,
                ChessPieceType.Knight,
                ChessPieceType.Bishops,
                ChessPieceType.King,
                ChessPieceType.Queen,
                ChessPieceType.Bishops,
                ChessPieceType.Knight,
                ChessPieceType.Rook,
            };

            placeRowTemplate(row: 0, color: ChessPieceColor.White, rowTypes: backRowPieces);
            placeRowWith(row: 1, color: ChessPieceColor.White, type: ChessPieceType.Pawn);

            placeRowWith(row: 6, color: ChessPieceColor.Black, type: ChessPieceType.Pawn);
            placeRowTemplate(row: 7, color: ChessPieceColor.Black, rowTypes: backRowPieces);
        }

        public void placeRowTemplate(int row, ChessPieceColor color, ChessPieceType[] rowTypes) {
            for (int c = 0; c < rowTypes.Length; c++) {
                ChessPieceType type = rowTypes[c];

                chessBoard[row, c] = new ChessPiece(
                    color: color,
                    type: type,
                    position: new Position(row, c)
                );
            }
        }

        public void placeRowWith(int row, ChessPieceColor color, ChessPieceType type) {
            for (int c = 0; c < chessBoard.GetLength(1); c++) {
                chessBoard[row, c] = new ChessPiece(
                    color: color,
                    type: type,
                    position: new Position(row, c)
                );
            }
        }

        private bool positionValid(Position position) {
            return position.row >= 0 && position.row <= 7 &&
                position.column >= 0 && position.column <= 7;
        }

        public void doMove(Position fromPosition, Position toPosition) {
            if (checkMove(fromPosition, toPosition)) {
                ChessPiece fromChessPiece = chessBoard[fromPosition.row, fromPosition.column];

                chessBoard[fromPosition.row, fromPosition.column] = null;
                chessBoard[toPosition.row, toPosition.column] = fromChessPiece;
            } else {
                throw new Exception("This chesspiece can't do that move.");
            }
        }

        private bool checkMove(Position fromPosition, Position toPosition) {
            if (!positionValid(fromPosition)) throw new Exception("The start position is not valid.");
            if (!positionValid(toPosition)) throw new Exception("The end position is not valid.");

            ChessPiece fromChessPiece = chessBoard[fromPosition.row, fromPosition.column];
            ChessPiece toChessPiece = chessBoard[toPosition.row, toPosition.column];

            if (fromChessPiece == null) throw new Exception("There is not chess piece at the start position.");
            if (toChessPiece != null) throw new Exception("There is a chess piece at the end position.");

            return validMove(fromPosition, toPosition);
        }

        private bool validMove(Position fromPosition, Position toPosition) {
            ChessPiece chessPiece = chessBoard[fromPosition.row, fromPosition.column];
            ChessPieceType chessPieceType = chessPiece.type;

            int differenceHorizontal = Math.Abs(fromPosition.column - toPosition.column);
            int differenceVertical = Math.Abs(fromPosition.row - toPosition.row);

            return moveCheckMap[chessPieceType](differenceHorizontal, differenceVertical);
        }
    }
}
